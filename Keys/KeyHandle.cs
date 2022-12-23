using ResurrectedEternalSkeens.Clockwork;
using System;

namespace ResurrectedEternal.Keys
{
    class KeyHandle
    {
        public KeyHandle(Action func)
        {
            Handle = func;
        }

        public bool Down;
        public bool Press;
        public Action Handle;

        public bool Elapsed => GetElapsed();
        private float _cur = 0;
        private float _max = .2f;
        private bool GetElapsed()
        {
            _cur += Clock.DeltaTime;
            if (_cur >= _max)
            {
                _cur = _max;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            Press = false;
            Down = false;
            _cur = 0;
        }
    }
}
