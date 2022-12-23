
using ResurrectedEternal.Keys;
using ResurrectedEternal.MemoryManager;
using ResurrectedEternalSkeens.Skills.GamePlaySkillMods;
using ResurrectedEternalSkeens.ClientObjects;
using ResurrectedEternalSkeens.ClientObjects.Cvars;
using ResurrectedEternalSkeens.Clockwork;
using ResurrectedEternalSkeens.Configs;
using ResurrectedEternalSkeens.Configs.ConfigSystem;
using ResurrectedEternalSkeens.Events;
using ResurrectedEternalSkeens.GenericObjects;
using ResurrectedEternalSkeens.Memory;
using ResurrectedEternalSkeens.Params.CSHelper;
using ResurrectedEternalSkeens.Skills;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using ResurrectedEternalSkeens;

namespace RRFull
{
    class Henker
    {
        public static Henker Singleton;
        public MemoryLoader Memory;
        public Engine Engine;
        public Client Client;
        public ConvarManager ConvarManager;
        public long m_lCurrentFPS = 0;
        private long m_lRenderedFrames = 0;
        private DateTime m_dtPOreviousFrameUpdate = DateTime.Now;
        private DateTime m_dtPreviousDeltaUpdate = DateTime.Now;
        private Thread m_tEntityUpdateThread;
        private List<SkillMod> m_aSkillMods = new List<SkillMod>();
        private bool m_bPprocessActive = false;

        public Henker()
        {
            new KeyMaster();
            ConsoleHelper.Write("[Resurrected Lite F8]\n", ConsoleColor.Blue);
            g_Globals.Offset = Offsets.Load();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;
            Clock.Initialize();

            // create event listener for panic key press
            EventManager.OnPanic += EventManager_OnPanic;

            //we might aswell call Start in here and leave it private.
            Singleton = this;
            Start();

        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //Console.WriteLine(e.ToString());
        }

        private void CurrentDomain_FirstChanceException(object sender, FirstChanceExceptionEventArgs e)
        {
            //Console.WriteLine(e.Exception.ToString());
        }

        private Modus previousMode;
        private void EventManager_OnPanic(bool obj)
        {
            if (obj)
            {
                previousMode = StateMachine.ClientModus;
                StateMachine.ClientModus = Modus.leaguemode;
                return;
            }

            StateMachine.ClientModus = previousMode;


        }

        private void Start()
        {
            Memory = new MemoryLoader("csgo");
            Memory.OnProcessLoaded += Memory_OnProcessLoaded;
            Memory.OnProcessExited += Memory_OnProcessExited;
            Memory.Query();
           
        }

        private void Memory_OnProcessExited()
        {
            Environment.Exit(0);
        }

        private ParamManager paramManager;


        private void Memory_OnProcessLoaded()
        {
            
            ConfigFactory.TryLoadConfig();
            //instantiate netvarmanager once.
            new NetVarManager();
            if (g_Globals.Offset.m_dwGetAllClasses == 0
                || g_Globals.Offset.dwViewMatrix == 0
                || g_Globals.Offset.dwEntityList == 0
                || g_Globals.Offset.dwGameRulesProxy == 0
                || g_Globals.Offset.dwGlowObjectManager == 0
                || g_Globals.Offset.dwRadarBase == 0
                || g_Globals.Offset.dwForceJump == 0
                || g_Globals.Offset.dwForceAttack == 0)
                ConsoleHelper.ConfirmAction("Couldnt catch all Unicorns!\n Starting anyway...\n");
            

            Engine = new Engine(Memory.Modules["engine.dll"], (uint)g_Globals.Offset.dwClientState);
            Client = new Client(Memory.Modules["client.dll"], (uint)g_Globals.Offset.dwEntityList, Engine);
            ConvarManager = new ConvarManager();
            m_bPprocessActive = true;
            paramManager = new ParamManager();
            Create();         
            paramManager.Hook();
        }



        private void Create()
        {
            m_aSkillMods.Add(new SkillModVisible(Engine, Client));
            m_aSkillMods.Add(new SkillModAim(Engine, Client));
            m_aSkillMods.Add(new SkillModNeon(Engine, Client));
            m_aSkillMods.Add(new SkillModHBTrigger(Engine, Client));
            m_aSkillMods.Add(new SkillModBunny(Engine, Client));
            m_aSkillMods.Add(new SkillModSkin(Engine, Client));
            m_tEntityUpdateThread = new Thread(EntityUpdate);
            m_tEntityUpdateThread.Name = "#" + Generators.GetRandomString(10);
            m_tEntityUpdateThread.SetApartmentState(ApartmentState.STA);
            m_tEntityUpdateThread.Start();
        }

        private void EntityUpdate()
        {


            while (!Memory.Reader.IsDisposed)
            {
                if (Memory.Reader.IsDisposed)
                    break;

                try
                {
                    foreach (var item in m_aSkillMods)
                    {
                        item.Start();
                    }
                    var _updateResult = Client.Update();
                    switch (_updateResult)
                    {
                        case UpdateResult.OK:
                            RunModules();
                            break;
                        case UpdateResult.NewState:
                        case UpdateResult.LevelChanged:
                        case UpdateResult.Pending:
                        case UpdateResult.None:
                        default:
                            Thread.Sleep(1);
                            break;
                    }
                    foreach (var item in m_aSkillMods)
                    {
                        item.End();
                    }

                    m_dtPreviousDeltaUpdate = DateTime.Now;
                    CalculateFramesPerSecond();

                }
                catch (Exception e)
                {
                    //throw e;
                    //Program.Log(e.ToString());
                    Client.Dirty();
                }
                //Thread.Sleep(1);
            }
            //Console.WriteLine("Process Exited?");
            Environment.Exit(0);
        }

        private void RunModules()
        {
            foreach (var item in m_aSkillMods)
                item.Before();

            foreach (var item in m_aSkillMods)
                item.Update();

            foreach (var item in m_aSkillMods)
                item.AfterUpdate();
        }

        private void CalculateFramesPerSecond()
        {
            m_lRenderedFrames++;
            if ((DateTime.Now - m_dtPOreviousFrameUpdate).TotalSeconds >= 1)
            {
                m_lCurrentFPS = m_lRenderedFrames;
                m_lRenderedFrames = 0;
                m_dtPOreviousFrameUpdate = DateTime.Now;
                //Console.WriteLine(m_lCurrentFPS.ToString());
            }
        }

    }

}
