﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.Events.EventArgs
{
    public enum BombEntityStateChange
    {
        Planted,
        Exploded,
        Dropped,
        Picked,
        BeforeExplosion,
        Defused
    }
    public class BombEntityChangedEventArgs
    {
        public BombEntityStateChange NewState;

        public BombEntityChangedEventArgs(BombEntityStateChange _state)
        {
            NewState = _state;
            EventManager.Notify(this);
        }
    }
}
