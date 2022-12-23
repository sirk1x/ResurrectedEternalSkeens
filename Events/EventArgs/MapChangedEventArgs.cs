using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.Events.EventArgs
{
    public class MapChangedEventArgs
    {
        public string MapName;
        public string OldMap;

        public MapChangedEventArgs(string old, string now)
        {
            MapName = now;
            OldMap = old;
            EventManager.Notify(this);
        }

    }
}
