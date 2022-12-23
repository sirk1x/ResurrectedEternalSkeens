using System.Runtime.InteropServices;

namespace ResurrectedEternalSkeens.BSPParse
{
    [StructLayout(LayoutKind.Sequential)]
    public struct dgamelumpheader_t
    {
        public int m_LumpCount;
    }
}
