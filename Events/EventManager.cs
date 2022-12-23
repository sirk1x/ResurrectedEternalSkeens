using ResurrectedEternalSkeens.Events.EventArgs;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.Events
{
    public static class EventManager
    {
        
        public static event Action<SignonState> OnEngineStateChanged;
        public static event Action OnConvarShow;
        public static event Action<BasePlayerChangedEventArgs> OnPlayerChanged;
        public static event Action<BombEntityChangedEventArgs> BombEntityChanged;
        public static event Action<Vector3> OnEmitHeartbeat;
        public static event Action<GameSenseChangedEventArgs> OnGameSenseChanged;
        public static event Action<GameSenseRoundChangedEventArgs> OnGameSenseRoundChanged;
        public static event Action<GameSenseGamePhaseChangedEventArgs> OnGameSenseRoundPhaseChanged;
        public static event Action<MapChangedEventArgs> OnMapChanged;
        public static event Action<WindowState> WindowStateChanged;
        public static event Action<MenuState> MenuStateChanged;
        public static event Action<ClientMode> OnClientModeChanged;
        public static event Action SkillReloadSkins;
        public static event Action EngineForceUpdate;
        public static event Action<bool> OnPanic;

        public static void Notify(bool _panic)
        {
            OnPanic?.Invoke(_panic);
        }

        public static void Notify(Vector3 heartBeatWorldPosition)
        {
            OnEmitHeartbeat?.Invoke(heartBeatWorldPosition);
        }


        public static void Notify(BasePlayerChangedEventArgs _playerEventArgs)
        {
            OnPlayerChanged?.Invoke(_playerEventArgs);
        }        
        public static void Notify(BombEntityChangedEventArgs _bombArgs)
        {
            BombEntityChanged?.Invoke(_bombArgs);
        }


        public static void Notify(SignonState _signState)
        {
            OnEngineStateChanged?.Invoke(_signState);
        }


        //public static void Notify(GameSenseEventArgs _event)
        //{
        //    OnGameSenseChanged?.Invoke(_event);
        //}
        public static void Notify(GameSenseChangedEventArgs _event)
        {
            OnGameSenseChanged?.Invoke(_event);
        }
        public static void Notify(GameSenseGamePhaseChangedEventArgs _event)
        {
            OnGameSenseRoundPhaseChanged?.Invoke(_event);
        }
        public static void Notify(GameSenseRoundChangedEventArgs _event)
        {
            OnGameSenseRoundChanged?.Invoke(_event);
        }

        public static void Notify(MapChangedEventArgs _event)
        {
            OnMapChanged?.Invoke(_event);
        }

        public static void Notify(WindowState _newWindowState)
        {
            WindowStateChanged?.Invoke(_newWindowState);
        }
        public static void Notify(MenuState _newMenuState)
        {
            MenuStateChanged?.Invoke(_newMenuState);
        }

        public static void ForceUpdate()
        {
            EngineForceUpdate?.Invoke();
        }

        //public static void Notify(ClientMode clientMode)
        //{
        //    OnClientModeChanged?.Invoke(clientMode);
        //}

        public static void ShowConvars()
        {
            OnConvarShow?.Invoke();
        }

        public enum MenuState
        {
            Open,
            Close
        }

        public enum WindowState
        {
            Foreground,
            Background
        }

        internal static void ReloadSkins()
        {
            SkillReloadSkins?.Invoke();
        }
    }
}
