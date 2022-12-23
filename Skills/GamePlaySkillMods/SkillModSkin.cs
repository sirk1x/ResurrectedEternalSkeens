using ResurrectedEternalSkeens.Globals;
using ResurrectedEternalSkeens.ClientObjects;
using ResurrectedEternalSkeens.Events;
using System;
using System.Collections.Generic;

namespace ResurrectedEternalSkeens.Skills.GamePlaySkillMods
{
    public class xSkin
    {


        public uint fallBackPaint;
        public int m_iItemIdHigh = -1;
        public int m_iEntityQuality = 99;
        public float m_flFallBackWear = 0.0001f;
        public string m_szCustomName = Meme.GenerateName();
        public int m_iFallBackSeed = Generators.random.Next(0, int.MaxValue);
    }
    class SkillModSkin : SkillMod
    {
        private short itemId = 500;
        private uint _KnifeId = 0;
        private const int itemIdHigh = -1;
        private const int entityQuality = 99;
        private const float fallbackWear = 0.0001f;

        private bool _reloadPending = false;

        private Dictionary<KNIFEINDEX, ItemDefinitionIndex> ReverseDictionary = new Dictionary<KNIFEINDEX, ItemDefinitionIndex>();

        private Dictionary<ItemDefinitionIndex, xSkin> SkinDictionary = new Dictionary<ItemDefinitionIndex, xSkin>();
        public SkillModSkin(Engine engine, Client client) : base(engine, client)
        {
            EventManager.SkillReloadSkins += EventManager_SkillReloadSkins;

            for (int i = 0; i < Enum.GetValues(typeof(KNIFEINDEX)).Length; i++)
            {
                ReverseDictionary.Add((KNIFEINDEX)i, (ItemDefinitionIndex)Enum.Parse(typeof(ItemDefinitionIndex), ((KNIFEINDEX)i).ToString()));
            }
            SkinDictionary = Skeens.Create();


        }

        private void EventManager_SkillReloadSkins()
        {
            _reloadPending = true;
        }

        public override bool Update()
        {

            return base.Update();
        }

        public override void AfterUpdate()
        {
            base.AfterUpdate();
        }

        private int KnifeOffset;
        //private IntPtr _weaponHandle;
        //private int _currentWeaponId;
        private Random r = new Random();

        private string _name = Meme.GenerateName();

        public override void Before()
        {
            base.Before();

            if (!Client.UpdateModules
                || !Engine.IsInGame
                || Client.LocalPlayer == null
                || !Client.LocalPlayer.IsValid
                || !Client.LocalPlayer.m_bIsAlive)
            {
                return;
            }

            if(_reloadPending)
            {
                _reloadPending = false;
                SkinDictionary = Skeens.Create();
            }

            //if (_vmdraw == null)
            //    _vmdraw = new ConVar("vm_draw_addon", typeof(int));

            _KnifeId = Client.NetworkStringTable.GetModelByIndex(Generators.ModelStringByItemDefinitionIndex((KNIFEINDEX)g_Globals.Config.OtherConfig.Knifemodel.Value));
            //itemId = Convert.ToInt16(ReverseDictionary[(KNIFEINDEX)g_Globals.Config.ExtraConfig.Knifemodel.Value]);
            KnifeOffset = _KnifeId < 10 ? 0 : 1;
            //if (Engine.GlobalVars.m_flAbsoluteFrameTime < 0.001f)

            foreach (var weapon in Client.LocalPlayer.m_hMyWeapons)
            {
                if (weapon == null || !weapon.IsValid || weapon.m_bDormant || !Generators.IsWeapon(weapon.ClientClass)) continue;
                var m_iAcountId = weapon.m_iAccountId;
                var _originalOwner = weapon.m_OriginalOwnerXuidLow;
                var _wpidx = weapon.m_iItemDefinitionIndex;
                xSkin _skin = null;
                if (SkinDictionary.ContainsKey(_wpidx))
                    _skin = SkinDictionary[_wpidx];

                switch (_wpidx)
                {
                    case ItemDefinitionIndex.KNIFE:
                    case ItemDefinitionIndex.KNIFE_T:
                    case ItemDefinitionIndex.KNIFE_BAYONET:
                    case ItemDefinitionIndex.KNIFE_FLIP:
                    case ItemDefinitionIndex.KNIFE_GUT:
                    case ItemDefinitionIndex.KNIFE_KARAMBIT:
                    case ItemDefinitionIndex.KNIFE_M9_BAYONET:
                    case ItemDefinitionIndex.KNIFE_TACTICAL:
                    case ItemDefinitionIndex.KNIFE_FALCHION:
                    case ItemDefinitionIndex.KNIFE_SURVIVAL_BOWIE:
                    case ItemDefinitionIndex.KNIFE_BUTTERFLY:
                    case ItemDefinitionIndex.KNIFE_PUSH:
                    case ItemDefinitionIndex.KNIFE_SURVIVAL:
                    case ItemDefinitionIndex.KNIFE_URSUS:
                    case ItemDefinitionIndex.KNIFE_GYPSY_JACKKNIFE:
                    case ItemDefinitionIndex.KNIFE_NOMAD:
                    case ItemDefinitionIndex.KNIFE_STILETTO:
                    case ItemDefinitionIndex.KNIFE_WIDOWMAKER:
                    case ItemDefinitionIndex.KNIFE_SKELETON:

                        if (_wpidx != (ItemDefinitionIndex)itemId)
                        {
                            weapon.m_iItemDefinitionIndex = ReverseDictionary[(KNIFEINDEX)g_Globals.Config.OtherConfig.Knifemodel.Value];
                            weapon.m_nModelIndex = _KnifeId;
                            weapon.m_nViewModelIndex = _KnifeId;//Client.NetworkStringTable.GetModelByIndex(Generators.ModelStringByItemDefinitionIndex((KNIFEINDEX)g_Globals.Config.ExtraConfig.Knifemodel.Value));
                            weapon.m_iEntityQuality = entityQuality;
                            weapon.m_nFallbackSeed = r.Next(9, int.MaxValue);
                        }

                        if (_skin == null)
                            continue;

                        weapon.m_iItemIdHigh = -1;
                        weapon.m_nFallbackPaintKit = _skin.fallBackPaint;
                        weapon.m_flFallbackWear = _skin.m_flFallBackWear;
                        weapon.m_iEntityQuality = _skin.m_iEntityQuality;
                        weapon.m_iAccountId = _originalOwner;

                        weapon.m_flFallbackWear = fallbackWear;
                        weapon.m_szCustomString = _name;
                        break;
                    default:
                        if (_skin == null)
                            continue;

                        weapon.m_iItemIdHigh = -1;
                        weapon.m_nFallbackPaintKit = _skin.fallBackPaint;
                        weapon.m_flFallbackWear = _skin.m_flFallBackWear;
                        weapon.m_iEntityQuality = _skin.m_iEntityQuality;
                        weapon.m_nFallbackSeed = _skin.m_iFallBackSeed;
                        weapon.m_nFallbackStatTrak = 1337;
                        weapon.m_iAccountId = _originalOwner;
                        weapon.m_szCustomString = _skin.m_szCustomName;
                        break;
                }

            }


            var _currentWeapon = Client.LocalPlayer.m_hActiveWeapon;
            if (_currentWeapon == null || !_currentWeapon.IsValid)
                return;
            if (Generators.GetWeaponType(_currentWeapon.m_iItemDefinitionIndex) == WeaponClass.KNIFE)
            {
                var _active = Client.LocalPlayer.m_hViewModelWeapon;
                if (_active == null || !_active.IsValid || _active.m_bDormant)
                    return;

                var _index = _active.m_nModelIndex;
                if (_index != _KnifeId)
                {
                    //_vmdraw.SetValue(0);
                    _active.m_nModelIndex = _KnifeId;
                    //_vmdraw.SetValue(1);
                }



            }



        }


    }
}
