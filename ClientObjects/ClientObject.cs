﻿using ResurrectedEternalSkeens.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.ClientObjects
{
    class ClientObject
    {
        public IntPtr ModuleAddress;

        public IntPtr Pointer;


        public ClientObject(IntPtr moduleAddress, uint offset)
        {
            ModuleAddress = moduleAddress;
            Pointer = MemoryLoader.instance.Reader.Read<IntPtr>(ModuleAddress + (int)offset);
        }

        public bool Update()
        {
            return true;
        }

    }
}
