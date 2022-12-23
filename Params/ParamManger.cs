using ResurrectedEternalSkeens.ClientObjects;
using ResurrectedEternalSkeens.Configs;
using ResurrectedEternalSkeens.Events;
using ResurrectedEternalSkeens.Events.EventArgs;
using ResurrectedEternalSkeens.GenericObjects;
using ResurrectedEternalSkeens.Params;
using ResurrectedEternalSkeens.Params.CSHelper;
using ResurrectedEternalSkeens.Skills;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens
{



    public class ParamManager
    {
        public static ParamManager instance;

        public ParamManager()
        {
            instance = this;
        }


        public void Hook()
        {
            HookConsole();
        }

        //This breaks when a config gets reloaded so we have to repopulate shit if we load another config.

        //MyKeys.Add(VirtualKeys.Insert, new KeyHandle(ReloadConfig));
        //    MyKeys.Add(VirtualKeys.F1, new KeyHandle(ForceUpdate));
        //    MyKeys.Add(VirtualKeys.F2, new KeyHandle(SwitchKnife));
        //    MyKeys.Add(VirtualKeys.F6, new KeyHandle(SwitchBunnyhop));
        //    MyKeys.Add(VirtualKeys.F8, new KeyHandle(SwitchGlowWeapons));
        //    MyKeys.Add(VirtualKeys.F7, new KeyHandle(SwitchGlow));
        //    MyKeys.Add(VirtualKeys.F9, new KeyHandle(SwitchAssistance));
        //    MyKeys.Add(VirtualKeys.F11, new KeyHandle(SwitchTrigger));
        //MyKeys.Add(VirtualKeys.OEMComma, new KeyHandle(DecreaseSmooth));
            //MyKeys.Add(VirtualKeys.OEMPeriod, new KeyHandle(IncreaseSmooth));
           // MyKeys.Add(VirtualKeys.N9, new KeyHandle(DecreaseFov));
            //MyKeys.Add(VirtualKeys.N0, new KeyHandle(IncreaseFov));

        public void ClearAndPrint()
        {
            Console.Clear();
            ConsoleHelper.Write("[Bootup Sequence Completed]\n", ConsoleColor.Green);
            ConsoleHelper.Write($"Welcome. Everything loaded! Enjoy your game!\n");
            ConsoleHelper.Write("Controls: F1 - Force Update.\n");
            ConsoleHelper.Write("Controls: F2 - Next Knife.\n");
            ConsoleHelper.Write("Controls: F6 - Switch Bunnyhop On/Off.\n");
            ConsoleHelper.Write("Controls: F7 - Switch Glow On/Off.\n");
            ConsoleHelper.Write("Controls: F8 - Switch Weapon/Defuse/Bomb/Chicken Glow On/Off.\n");
            ConsoleHelper.Write("Controls: F9 - Switch Aimbot On/Off.\n");
            ConsoleHelper.Write("Controls: F11 - Switch Trigger On/Off.\n");
            ConsoleHelper.Write("Controls: 9 / 0 - Decrease / Increase Aimbot Angle.\n");
            ConsoleHelper.Write("Controls: , / . - Decrease / Increase Smooth.\n");
            ConsoleHelper.Write("Skin ids are located in: /configs/skeens.txt\n");
            ConsoleHelper.Write("Config is located at: /configs/config.json\n");
            ConsoleHelper.Write("Press Insert to reload all configs.\n");
            //ConsoleHelper.Write("Edit the Config and press Insert to reload the config.\n");
        }

        private void HookConsole()
        {

            ClearAndPrint();

            while (true)
            {
                ConsoleHelper.CaptureInput();
            }
        }

    }
}
