﻿using System.Runtime.InteropServices;

namespace ResurrectedEternalSkeens.BSPParse
{
    [StructLayout(LayoutKind.Sequential)]
    struct dplane_t
    {
        public Vector3 m_Normal;
        public float m_Distance;
        public byte m_Type;
    }
}
