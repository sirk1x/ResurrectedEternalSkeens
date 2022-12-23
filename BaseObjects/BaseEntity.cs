using ResurrectedEternalSkeens.Memory;
using RRFull;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.BaseObjects
{
    public class BaseEntity
    {
        public IntPtr BaseAddress;

        public ClientClass ClientClass;

        public bool m_bIsActive
        {
            get
            {
                if (IsNullPtr)
                    return false;
                if (!IsValid)
                    return false;
                if (m_bDormant)
                    return false;
                if (!m_bIsAlive)
                    return false;
                if (m_iHealth <= 0)
                    return false;

                return true;
            }
        }

        public bool IsNullPtr
        {
            get { return BaseAddress == IntPtr.Zero; }
        }

        private DateTime m_dtLastIndexCheck = DateTime.Now.AddSeconds(-1);
        private TimeSpan m_tsIndexScanCheck = TimeSpan.FromMilliseconds(30);
        private int m_piIndex;
        public int m_iIndex
        {
            get
            {
                return m_piIndex;
            }
            set { m_piIndex = value; }
        }

        public int m_fFlags
        {
            get { return MemoryLoader.instance.Reader.Read<int>(BaseAddress + (int)g_Globals.Offset.m_fFlags); }
        }

        public bool m_bDormant
        {
            get { return MemoryLoader.instance.Reader.Read<int>(BaseAddress + (int)g_Globals.Offset.m_bDormant) == 1; }
        }

        public Vector3 m_vecOrigin
        {
            //set { m_pvecOrigin = value; }
            get { return MemoryLoader.instance.Reader.Read<Vector3>(BaseAddress + (int)g_Globals.Offset.m_vecOrigin); }
        }

        public Quaternion m_angRotation
        {
            get { return MemoryLoader.instance.Reader.Read<Quaternion>(BaseAddress + (int)g_Globals.Offset.m_angRotation); }
        }

        //byte?
        public uint m_nModelIndex
        {
            get { return MemoryLoader.instance.Reader.Read<uint>(BaseAddress + (int)g_Globals.Offset.m_nModelIndex); }
            set { MemoryLoader.instance.Reader.Write<uint>(BaseAddress + (int)g_Globals.Offset.m_nModelIndex, value); }
        }

        public int m_iSpottedByMask
        {
            get
            {
                return MemoryLoader.instance.Reader.Read<int>(BaseAddress + g_Globals.Offset.m_bSpottedByMask);
            }
        }

        public int m_iTeamNum
        {
            get { return MemoryLoader.instance.Reader.Read<int>(BaseAddress + (int)g_Globals.Offset.m_iTeamNum); }
        }

        public bool m_bIsAlive
        {
            get { return MemoryLoader.instance.Reader.Read<byte>(BaseAddress + (int)g_Globals.Offset.m_lifeState) == 0; }

        }
        public int m_iHealth
        {
            get { return MemoryLoader.instance.Reader.Read<int>(BaseAddress + (int)g_Globals.Offset.m_iHealth); }
        }

        public byte m_nRenderMode
        {
            get { return MemoryLoader.instance.Reader.Read<byte>(BaseAddress + (int)g_Globals.Offset.m_nRenderMode); }
            set { MemoryLoader.instance.Reader.Write<byte>(BaseAddress + (int)g_Globals.Offset.m_nRenderMode, value); }
        }
        public byte m_nRenderFX
        {
            get { return MemoryLoader.instance.Reader.Read<byte>(BaseAddress + (int)g_Globals.Offset.m_nRenderFX); }
            set { MemoryLoader.instance.Reader.Write<byte>(BaseAddress + (int)g_Globals.Offset.m_nRenderFX, value); }
        }

        public Color m_clrRender
        {
            get { return MemoryLoader.instance.Reader.Read<Color>(BaseAddress + (int)g_Globals.Offset.m_clrRender); }
            set { MemoryLoader.instance.Reader.Write<Color>(BaseAddress + (int)g_Globals.Offset.m_clrRender, value); }
        }
        public string m_szModelName
        {
            get { return MemoryLoader.instance.Reader.ReadString(m_nModelBase + 0x04, Encoding.Default, 128); }
        }
        private IntPtr m_nModelBase
        {
            get { return MemoryLoader.instance.Reader.Read<IntPtr>(BaseAddress + 0x6C); }
        }
        public PlayerTeam Team
        {
            get { return (PlayerTeam)m_iTeamNum; }
        }

        public ModelScaleType_t m_ScaleType
        {
            get { return (ModelScaleType_t)MemoryLoader.instance.Reader.Read<byte>(BaseAddress + (int)g_Globals.Offset.m_ScaleType); }
            set { MemoryLoader.instance.Reader.Write<byte>(BaseAddress + (int)g_Globals.Offset.m_ScaleType, Convert.ToByte(value)); }
        }
            

        public BaseEntity(IntPtr addr, ClientClass _classid)
        {
            if (addr == IntPtr.Zero)
                return;
            BaseAddress = addr;
            ClientClass = _classid;
            m_iIndex = m_piIndex = MemoryLoader.instance.Reader.Read<int>(BaseAddress + (int)g_Globals.Offset.m_dwIndex);
            //m_vecOrigin = ;
        }

        public string DistanceInMetresString(Vector3 _from)
        {
            return Math.Round(EngineMath.DistanceToOtherEntityInMetres(_from, m_vecOrigin)).ToString() + "M";
        }
        public float Distance(Vector3 _from)
        {
            return EngineMath.GetDistanceToPoint(_from, m_vecOrigin);
        }
        //&& Id < 2048 && Id >= 0
        public bool IsValid
        {
            get
            {
                try
                {
                    return BaseAddress != IntPtr.Zero && m_iIndex >= 0 && m_iIndex < 4096 && GetEntityPtr() != IntPtr.Zero;
                }
                catch { return false; }
            }
        }


        private IntPtr GetEntityPtr()
        {
            // ptr = entityList + (idx * size)
            try
            {
                if (m_iIndex < 0 || m_iIndex > 4096)
                    return IntPtr.Zero;
                return MemoryLoader.instance.Reader.Read<IntPtr>(Henker.Singleton.Client.Pointer + (m_iIndex - 1) * (int)g_Globals.Offset.EntitySize);
            }
            catch
            {
                //Console.WriteLine(id);
                return IntPtr.Zero;
            }

        }

        public float m_flModelScale
        {
            get { return MemoryLoader.instance.Reader.Read<float>(BaseAddress + g_Globals.Offset.m_flModelScale); }
            set { MemoryLoader.instance.Reader.Write(BaseAddress + g_Globals.Offset.m_flModelScale, value); }
        }

        public void SetSize(float amount)
        {
            MemoryLoader.instance.Reader.Write<float>(BaseAddress + 0x2748, amount);
        }

        public void SetShadowCastDistance(float amt)
        {
            MemoryLoader.instance.Reader.Write<float>(BaseAddress + 0x03A0, amt);
        }



    }
}
