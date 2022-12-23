using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternal.Keys
{
    public class KeyboardInfo
    {
        private KeyboardInfo() { }
        [DllImport("user32")]
        private static extern short GetKeyState(int vKey);
        public static KeyStateInfo GetKeyState(VirtualKeys key)
        {
            short keyState = GetKeyState((int)key);
            byte[] bits = BitConverter.GetBytes(keyState);
            bool toggled = bits[0] > 0, pressed = bits[1] > 0;
            return new KeyStateInfo(key, pressed, toggled);
        }
    }


    public struct KeyStateInfo
    {
        VirtualKeys _key;
        bool _isPressed,
            _isToggled;
        public KeyStateInfo(VirtualKeys key,
                        bool ispressed,
                        bool istoggled)
        {
            _key = key;
            _isPressed = ispressed;
            _isToggled = istoggled;
        }
        public static KeyStateInfo Default
        {
            get
            {
                return new KeyStateInfo(VirtualKeys.LeftButton,
                                            false,
                                            false);
            }
        }
        public VirtualKeys Key
        {
            get { return _key; }
        }
        public bool IsPressed
        {
            get { return _isPressed; }
        }
        public bool IsToggled
        {
            get { return _isToggled; }
        }
    }
}
