using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.Configs
{
    public class OtherConfig
    {
        public ConfigValueEntry Bunnyhop = new ConfigValueEntry
        {
            Header = "Other",
            Name = "Bunnyhop",
            MaxValue = true,
            MinValue = false,
            Value = true,
            //ValueType = typeof(bool),
            IsGrouped = true,
            GroupId = "row7"
        };
        public ConfigValueEntry FlashAlpha = new ConfigValueEntry
        {
            Name = "Flash Alpha",
            MaxValue = 255f,
            MinValue = 0f,
            Value = 122.5f,
            //ValueType = typeof(bool),
            IsGrouped = true,
            GroupId = "row7"
        };
        public ConfigValueEntry cTerroristNormalColor = new ConfigValueEntry
        {
            Header = "Bounding Box Color",
            Name = "Normal T",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.Yellow,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "bb_row1"
        };
        public ConfigValueEntry cTerroristVisibleColor = new ConfigValueEntry
        {
            Name = "Visible T",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.Red,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "bb_row1"
        };
        public ConfigValueEntry cCTerroristNormalColor = new ConfigValueEntry
        {
            Name = "Normal CT",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.RoyalBlue,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "bb_row2"
        };
        public ConfigValueEntry cCTerroristVisibleColor = new ConfigValueEntry
        {
            Name = "Visible CT",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.LimeGreen,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "bb_row2"
        };
        public ConfigValueEntry cBoundingBoxOutlineColor = new ConfigValueEntry
        {
            Name = "Outline",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.Black,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "bb_row3"
        };

        public ConfigValueEntry cImmunityColor = new ConfigValueEntry
        {
            Name = "Immunity",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.Fuchsia,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "bb_row3"
        };

        public ConfigValueEntry cNeonTerroristNormalColor = new ConfigValueEntry
        {
            Header = "Neon Colors",
            Name = "Normal T",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.Yellow,
            IsGrouped = true,
            GroupId = "neon_bb_row1"
            //ValueType = typeof(Color),
        };

        public ConfigValueEntry cNeonTerroristVisibleColor = new ConfigValueEntry
        {
            Name = "Visible T",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.Red,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "neon_bb_row1"
        };
        public ConfigValueEntry cNeonCTerroristNormalColor = new ConfigValueEntry
        {
            Name = "Normal CT",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.RoyalBlue,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "neon_bb_row2"
        };
        public ConfigValueEntry cNeonCTerroristVisibleColor = new ConfigValueEntry
        {
            Name = "Visible CT",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.LimeGreen,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "neon_bb_row2"
        };
        //#############################################
        // DROP COLORS START
        //#############################################


        public ConfigValueEntry cWeaponColor = new ConfigValueEntry
        {
            Header = "Drop Colors",
            Name = "Weapon",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.CornflowerBlue,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "droprow1"
        };
        public ConfigValueEntry cDefuseKitColor = new ConfigValueEntry
        {
            Name = "Defuse Kit",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.DeepPink,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "droprow1"
        };
        public ConfigValueEntry cGrenadeColor = new ConfigValueEntry
        {
            Name = "Grenade",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.Sienna,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "droprow2"
        };
        public ConfigValueEntry cBombColor = new ConfigValueEntry
        {
            Name = "Bomb",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.Crimson,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "droprow2"
        };
        public ConfigValueEntry cProjectileColor = new ConfigValueEntry
        {
            Name = "Projectile",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.DarkMagenta,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "droprow3"
        };

        public ConfigValueEntry cChickenColor = new ConfigValueEntry
        {
            Name = "Chicken",
            MaxValue = g_Globals.ColorManager.Count,
            MinValue = 0,
            Value = Color.Green,
            //ValueType = typeof(Color),
            IsGrouped = true,
            GroupId = "droprow4"
        };

        public ConfigValueEntry UseSpottedByMask = new ConfigValueEntry
        {
            Name = "SpottedByMask",
            MaxValue = true,
            MinValue = false,
            Value = true,
        };
        public ConfigValueEntry UseRayTrace = new ConfigValueEntry
        {
            Name = "RayTrace",
            MaxValue = true,
            MinValue = false,
            Value = false,
        };
        public ConfigValueEntry Knifemodel = new ConfigValueEntry
        {
            Name = "Knifemodel",
            MaxValue = Enum.GetValues(typeof(KNIFEINDEX)).Length - 1,
            MinValue = 0,
            Value = KNIFEINDEX.KNIFE_KARAMBIT,
            //ValueType = typeof(KNIFEINDEX),
            IsGrouped = true,
            GroupId = "row8"
        };
        public ConfigValueEntry GrenadeTrajectory = new ConfigValueEntry
        {
            Name = "Grenade Trajectory",
            MaxValue = true,
            MinValue = false,
            Value = false,
            ConvarName = "cl_grenadepreview",
        };
        public ConfigValueEntry WeaponSpread = new ConfigValueEntry
        {
            Name = "Weapon Spread",
            MaxValue = true,
            MinValue = false,
            Value = false,
            //ValueType = typeof(bool),
            ConvarName = "weapon_debug_spread_show",

        };
    }
}
