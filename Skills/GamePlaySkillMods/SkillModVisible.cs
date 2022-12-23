using ResurrectedEternalSkeens.BaseObjects;
using ResurrectedEternalSkeens.ClientObjects;
using ResurrectedEternalSkeens.ClientObjects.Cvars;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.Skills
{
    class SkillModVisible : SkillMod
    {
        private DateTime _lastUpdate = DateTime.Now;
        //no need to go hard on visual checks for the esp since the aimbot already does heavy checks
        private TimeSpan _interval = TimeSpan.FromMilliseconds(20);



        public SkillModVisible(Engine engine, Client client) : base(engine, client)
        {

        }

        public override void AfterUpdate()
        {
            base.AfterUpdate();
        }

        public override void Before()
        {
            base.Before();
            if (Client == null || !Client.UpdateModules || Client.LocalPlayer == null || !Client.LocalPlayer.IsValid /*|| !MapManager.VisibleCheckAvailable*/)
                return;

            if (DateTime.Now - _lastUpdate < _interval)
                return;

            CheckPlayers();
            CheckFlashProjectiles();
            CheckNuggets();
            Convars();
            _lastUpdate = DateTime.Now;

        }

        private void CheckPlayers()
        {
            foreach (var item in Filter.GetActivePlayers((TargetType)Config.AimbotConfig.AimAt.Value))
            {
                if (item.m_bIsActive)
                {
                    VisibleCheck _checkType = VisibleCheck.None;
                    if ((bool)Config.NeonConfig.UseRayTrace.Value && MapManager.VisibleCheckAvailable)
                        _checkType = VisibleCheck.RayTrace;
                    else if ((bool)Config.NeonConfig.UseSpottedByMask.Value)
                        _checkType = VisibleCheck.SlowTrace;
                    item.IsVisible = IsVisibleCheck(Client.LocalPlayer, item, _checkType);
                    item.m_dtLastVisCheck = DateTime.Now;
                    continue;
                }
                else
                    item.IsVisible = false;
            }
        }

        private void CheckFlashProjectiles()
        {
            var _locPos = Client.LocalPlayer.m_vecHead;
            foreach (var item in Client.GetProjectiles())
            {
                if (!Generators.IsFlashbang(item.m_szModelName)) continue;
                //by mask does not work with flashbangs
                if (item.IsValid && (bool)Config.OtherConfig.UseRayTrace.Value && MapManager.VisibleCheckAvailable)
                {
                    item.IsVisible = IsVisibleCheck(Client.LocalPlayer.m_vecHead, item.m_vecOrigin);
                }
                else
                    item.IsVisible = false;
            }
        }

        private void CheckNuggets()
        {

            foreach (var item in Client.GetChicks())
            {
                if (!item.m_bIsActive)
                {
                    if ((bool)Config.OtherConfig.UseRayTrace.Value && MapManager.VisibleCheckAvailable)
                        item.Visible = IsVisibleCheck(Client.LocalPlayer.m_vecHead, item.Head);
                    else if ((bool)Config.OtherConfig.UseSpottedByMask.Value)
                        item.Visible = VisibleByMask(item);
                    else
                        item.Visible = false;
                }
                else
                    item.Visible = false;
            }

        }
        private ConvarEntity m_ceGrenadePreview;
        private ConvarEntity m_ceSpreadCrosshair;


        private void Convars()
        {
            if (m_ceGrenadePreview == null)
                m_ceGrenadePreview = ConvarManager.instance.GetConvar(g_Globals.Config.OtherConfig.GrenadeTrajectory.ConvarName);
            if (m_ceSpreadCrosshair == null)
                m_ceSpreadCrosshair = ConvarManager.instance.GetConvar(g_Globals.Config.OtherConfig.WeaponSpread.ConvarName);

            m_ceGrenadePreview.m_nValue = Convert.ToInt32(g_Globals.Config.OtherConfig.GrenadeTrajectory.Value);
            m_ceSpreadCrosshair.m_nValue = Convert.ToInt32(g_Globals.Config.OtherConfig.WeaponSpread.Value);
        }

        public override bool IsVisibleCheck(LocalPlayer _p, BasePlayer _target, VisibleCheck _checkType)
        {
            return base.IsVisibleCheck(_p, _target, _checkType);
        }

        public override bool VisibleByMask(BaseEntity _entity)
        {
            return base.VisibleByMask(_entity);
        }

        public override bool IsVisibleCheck(Vector3 from, Vector3 tp)
        {
            return base.IsVisibleCheck(from, tp);
        }

        public override bool Update()
        {
            return base.Update();
        }
    }
}
