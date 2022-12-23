using ResurrectedEternalSkeens.Keys;
using ResurrectedEternalSkeens.Events;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ResurrectedEternalSkeens;

namespace ResurrectedEternal.Keys
{
    class KeyMaster
    {
        private Dictionary<VirtualKeys, KeyHandle> MyKeys = new Dictionary<VirtualKeys, KeyHandle>();
        private bool _isPanic = false;
        public KeyMaster()
        {
            //MyKeys.Add(VirtualKeys.Home, new KeyHandle(Panic));
            MyKeys.Add(VirtualKeys.Insert, new KeyHandle(ReloadConfig));
            MyKeys.Add(VirtualKeys.F1, new KeyHandle(ForceUpdate));
            MyKeys.Add(VirtualKeys.F2, new KeyHandle(SwitchKnife));
            MyKeys.Add(VirtualKeys.F6, new KeyHandle(SwitchBunnyhop));
            MyKeys.Add(VirtualKeys.F8, new KeyHandle(SwitchGlowWeapons));
            MyKeys.Add(VirtualKeys.F7, new KeyHandle(SwitchGlow));
            MyKeys.Add(VirtualKeys.F9, new KeyHandle(SwitchAssistance));
            MyKeys.Add(VirtualKeys.F11, new KeyHandle(SwitchTrigger));
            MyKeys.Add(VirtualKeys.OEMComma, new KeyHandle(DecreaseSmooth));
            MyKeys.Add(VirtualKeys.OEMPeriod, new KeyHandle(IncreaseSmooth));
            MyKeys.Add(VirtualKeys.N9, new KeyHandle(DecreaseFov));
            MyKeys.Add(VirtualKeys.N0, new KeyHandle(IncreaseFov));
            //MyKeys.Add(VirtualKeys.F11, new KeyHandle(SwitchTrigger));
           
            Task.Factory.StartNew(() => HandleInput());
        }

        void SwitchKnife()
        {
            ReloadConfig();
            g_Globals.Config.OtherConfig.Knifemodel.Value = EnumCaster.Next((KNIFEINDEX)g_Globals.Config.OtherConfig.Knifemodel.Value);
            ResurrectedEternalSkeens.Configs.ConfigFactory.SaveConfig();
            ResurrectedEternalSkeens.ParamManager.instance.ClearAndPrint();
            Console.WriteLine("Knife Model: " + (KNIFEINDEX)g_Globals.Config.OtherConfig.Knifemodel.Value);
        }

        void ReloadConfig()
        {
            ResurrectedEternalSkeens.Configs.ConfigFactory.TryLoadConfig();
        }

        void ForceUpdate()
        {
            EventManager.ForceUpdate();

        }

        void DecreaseSmooth()
        {
            ReloadConfig();
            var _ent = g_Globals.Config.AimbotConfig.Smooth;
            var _next = (float)g_Globals.Config.AimbotConfig.Smooth.Value - (float)g_Globals.Config.AimbotConfig.Smooth.Incremental;
            _ent.Value = EngineMath.Clamp<float>(_next, (float)_ent.MinValue, (float)_ent.MaxValue);
           
            
            ResurrectedEternalSkeens.ParamManager.instance.ClearAndPrint();
            Console.WriteLine("Smooth: " + ((float)_ent.Value));
            //DecreaseRCSSmooth();
            ResurrectedEternalSkeens.Configs.ConfigFactory.SaveConfig();
        }

        void DecreaseRCSSmooth()
        {
            var _ent = g_Globals.Config.AimbotConfig.RCSSmoothOffset;
            var _next = (float)g_Globals.Config.AimbotConfig.RCSSmoothOffset.Value - (float)g_Globals.Config.AimbotConfig.RCSSmoothOffset.Incremental;
            _ent.Value = EngineMath.Clamp<float>(_next, (float)_ent.MinValue, (float)_ent.MaxValue);
            Console.WriteLine("SmoothOffset: " + ((float)_ent.Value));
        }



        void IncreaseSmooth()
        {
            ReloadConfig();
            var _ent = g_Globals.Config.AimbotConfig.Smooth;
            var _next = (float)g_Globals.Config.AimbotConfig.Smooth.Value + (float)g_Globals.Config.AimbotConfig.Smooth.Incremental;
            _ent.Value = EngineMath.Clamp<float>(_next, (float)_ent.MinValue, (float)_ent.MaxValue);
            
            ResurrectedEternalSkeens.ParamManager.instance.ClearAndPrint();
            Console.WriteLine("Smooth: " + ((float)_ent.Value));
            //IncreaseRCSSmooth();
            ResurrectedEternalSkeens.Configs.ConfigFactory.SaveConfig();
        }
        void IncreaseRCSSmooth()
        {
            var _ent = g_Globals.Config.AimbotConfig.RCSSmoothOffset;
            var _next = (float)g_Globals.Config.AimbotConfig.RCSSmoothOffset.Value + (float)g_Globals.Config.AimbotConfig.RCSSmoothOffset.Incremental;
            _ent.Value = EngineMath.Clamp<float>(_next, (float)_ent.MinValue, (float)_ent.MaxValue);
            Console.WriteLine("SmoothOffset: " + ((float)_ent.Value));
        }
        void DecreaseFov()
        {
            ReloadConfig();
            var _ent = g_Globals.Config.AimbotConfig.Angle;
            var _next = (float)g_Globals.Config.AimbotConfig.Angle.Value - (float)g_Globals.Config.AimbotConfig.Angle.Incremental;
            _ent.Value = EngineMath.Clamp<float>(_next, (float)_ent.MinValue, (float)_ent.MaxValue);
            ResurrectedEternalSkeens.Configs.ConfigFactory.SaveConfig();
            ResurrectedEternalSkeens.ParamManager.instance.ClearAndPrint();
            Console.WriteLine("Fov: " + (float)_ent.Value);
        }
        void IncreaseFov()
        {
            ReloadConfig();
            var _ent = g_Globals.Config.AimbotConfig.Angle;
            var _next = (float)g_Globals.Config.AimbotConfig.Angle.Value + (float)g_Globals.Config.AimbotConfig.Angle.Incremental;
            _ent.Value = EngineMath.Clamp<float>(_next, (float)_ent.MinValue, (float)_ent.MaxValue);
            ResurrectedEternalSkeens.Configs.ConfigFactory.SaveConfig();
            ResurrectedEternalSkeens.ParamManager.instance.ClearAndPrint();
            Console.WriteLine("Fov: " + ((float)_ent.Value));
        }
        void SwitchTrigger()
        {
            ReloadConfig();
            g_Globals.Config.AimbotConfig.trig_Enable.Value = !(bool)g_Globals.Config.AimbotConfig.trig_Enable.Value;
            ResurrectedEternalSkeens.Configs.ConfigFactory.SaveConfig();
            ResurrectedEternalSkeens.ParamManager.instance.ClearAndPrint();
            Console.WriteLine("Triggerbot: " + Cast((bool)g_Globals.Config.AimbotConfig.trig_Enable.Value));
        }

        void SwitchBunnyhop()
        {
            ReloadConfig();
            g_Globals.Config.OtherConfig.Bunnyhop.Value = !(bool)g_Globals.Config.OtherConfig.Bunnyhop.Value;
            ResurrectedEternalSkeens.Configs.ConfigFactory.SaveConfig();
            ResurrectedEternalSkeens.ParamManager.instance.ClearAndPrint();
            Console.WriteLine("Bunnyhop: " + Cast((bool)g_Globals.Config.OtherConfig.Bunnyhop.Value));
        }
        void SwitchGlowWeapons()
        {
            ReloadConfig();
            g_Globals.Config.NeonConfig.NeonGlowWeapons.Value = !(bool)g_Globals.Config.NeonConfig.NeonGlowWeapons.Value;
            g_Globals.Config.NeonConfig.NeonGlowBomb.Value = !(bool)g_Globals.Config.NeonConfig.NeonGlowBomb.Value;
            g_Globals.Config.NeonConfig.NeonGlowProjectiles.Value = !(bool)g_Globals.Config.NeonConfig.NeonGlowProjectiles.Value;
            g_Globals.Config.NeonConfig.NeonGlowChickens.Value = !(bool)g_Globals.Config.NeonConfig.NeonGlowChickens.Value;
            g_Globals.Config.NeonConfig.NeonGlowDefuse.Value = !(bool)g_Globals.Config.NeonConfig.NeonGlowDefuse.Value;
            g_Globals.Config.NeonConfig.NeonGlowGrenades.Value = !(bool)g_Globals.Config.NeonConfig.NeonGlowGrenades.Value;
            ResurrectedEternalSkeens.Configs.ConfigFactory.SaveConfig();
            ResurrectedEternalSkeens.ParamManager.instance.ClearAndPrint();
            Console.WriteLine("Other Glow: " + Cast((bool)g_Globals.Config.NeonConfig.NeonGlowDefuse.Value));
        }
        void SwitchGlow()
        {
            ReloadConfig();
            g_Globals.Config.NeonConfig.Enable.Value = !(bool)g_Globals.Config.NeonConfig.Enable.Value;
            ResurrectedEternalSkeens.Configs.ConfigFactory.SaveConfig();
            EventManager.ReloadSkins();
            ResurrectedEternalSkeens.ParamManager.instance.ClearAndPrint();
            Console.WriteLine("Glow: " + Cast((bool)g_Globals.Config.NeonConfig.Enable.Value));
        }
        void SwitchAssistance()
        {
            ReloadConfig();
            g_Globals.Config.AimbotConfig.Enable.Value = !(bool)g_Globals.Config.AimbotConfig.Enable.Value;
            ResurrectedEternalSkeens.Configs.ConfigFactory.SaveConfig();
            ResurrectedEternalSkeens.ParamManager.instance.ClearAndPrint();
            Console.WriteLine("Aimbot: " + Cast((bool)g_Globals.Config.AimbotConfig.Enable.Value));
        }
        void Panic()
        {
            _isPanic = !_isPanic;
            EventManager.Notify(_isPanic);
        }

        string Cast(bool val)
        {
            if (val)
                return "On";
            return "Off";
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetKeyState(int keyCode);

        private void HandleInput()
        {


            while (true)
            {
                try
                {
                    foreach (var item in MyKeys)
                    {
                        var _res = KeyboardInfo.GetKeyState(item.Key);


                        if (_res.IsPressed && !item.Value.Down)
                        {
                            item.Value.Down = true;
                            item.Value.Press = false;
                            item.Value.Handle();
                        }
                        else if (_res.IsPressed && item.Value.Down && item.Value.Elapsed)
                        {
                            item.Value.Press = true;
                            item.Value.Handle();
                        }
                        else
                        {
                            if (!_res.IsPressed && item.Value.Down)
                            {
                                item.Value.Reset();
                            }

                        }
                    }
                    System.Threading.Thread.Sleep(32);
                }
                catch { }

            }
        }
    }
}


