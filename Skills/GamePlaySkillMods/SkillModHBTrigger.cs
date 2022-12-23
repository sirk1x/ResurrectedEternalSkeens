using ResurrectedEternalSkeens.BaseObjects;
using ResurrectedEternalSkeens.ClientObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.Skills
{
    class SkillModHBTrigger : SkillMod
    {
        private DateTime _lastTrigger = DateTime.Now;
        private TimeSpan _Interval = TimeSpan.FromMilliseconds(10);
        public SkillModHBTrigger(Engine engine, Client client) : base(engine, client)
        {
        }

        public override void AfterUpdate()
        {
            base.AfterUpdate();
        }

        public override void Before()
        {
            base.Before();
        }

        private BasePlayer _lastTarget;

        public override bool Update()
        {

            if (!Client.UpdateModules || !(bool)Config.AimbotConfig.trig_Enable.Value 
                || Client.LocalPlayer == null 
                || Client.m_bMouseEnabled 
                || !Engine.IsInGame
                || !Client.LocalPlayer.m_bIsAlive
                || Client.LocalPlayer.m_bIsSpectator)
                return false;
            if (DateTime.Now - _lastTrigger < _Interval)
                return false;

            //cancel trigger if we have user input
            if (Convert.ToBoolean(RRWAPI.WAPI.GetAsyncKeyState((ushort)VirtualKeys.LeftButton) & 0x8000)
                || Convert.ToBoolean(RRWAPI.WAPI.GetAsyncKeyState((ushort)VirtualKeys.RightButton) & 0x8000))
                return false;

            if ((bool)Config.AimbotConfig.trig_KeyEnable.Value)
                if (!Convert.ToBoolean(RRWAPI.WAPI.GetAsyncKeyState((ushort)(VirtualKeys)Config.AimbotConfig.trig_Key.Value) & 0x8000))
                    return false;


            var _localWeapon = Client.LocalPlayer.m_hActiveWeapon;

            if (_localWeapon == null)
                return false;

            var _wpType = Client.LocalPlayer.GetWeaponId;

            switch (_wpType)
            {
                case WeaponClass.RIFLE:
                case WeaponClass.HEAVY:
                case WeaponClass.SMG:
                    if (!(bool)Config.AimbotConfig.trig_Rifle.Value)
                        return false;
                    break;
                case WeaponClass.SNIPER:
                    if (!(bool)Config.AimbotConfig.trig_Snipers.Value)
                        return false;
                    break;
                case WeaponClass.PISTOL:
                    if (!(bool)Config.AimbotConfig.trig_Pistols.Value)
                        return false;
                    break;
                case WeaponClass.KNIFE:
                case WeaponClass.OTHER:
                    return false;
                default:
                    return false;
            }

            if (_localWeapon.m_iClip == 0
                || _localWeapon.m_bInReload)
            {
                return false;
            }

            var _filtered = Filter.GetActivePlayers(TargetType.Enemy);

            if (_filtered.Count == 0)
                return false;

            _lastTarget = GetBestOffer(_filtered);

            if (_lastTarget == null)
                return false;        

            if (!_lastTarget.IsVisible)
                return false;

            if (Client.LocalPlayer.m_bCanShoot)
                Client.LocalPlayer.ForceAttack();
            _lastTrigger = DateTime.Now;
            return true;
        }


        private BasePlayer GetBestOffer(List<BasePlayer> _players)
        {
            var _eyePos = Client.LocalPlayer.m_vEyePosition;
            var _angles = Client.LocalPlayer.m_vViewAngles;
            foreach (var item in _players)
            {
                //item.ReadBones();
                if (!item.IsValid) continue;
                foreach (var bone in item.GetUpperBody())
                {
                    if (!item.IsVisible) continue;

                    if ((float)EngineMath.GetFov(_eyePos, _angles, bone) < .888f)
                        return item;
                }

            }
            return null;
        }
    }
}
