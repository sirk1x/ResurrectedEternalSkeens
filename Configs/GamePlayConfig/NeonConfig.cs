using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.Configs.GamePlayConfig
{
    public class NeonConfig
    {
        public ConfigValueEntry Enable = new ConfigValueEntry
        {
            Header = "Glow Configuration",
            Name = "Enable Neon",
            MaxValue = true,
            MinValue = false,
            Value = true,
            //ValueType = typeof(bool),
            IsGrouped = true,
            GroupId = "row1"
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
        public ConfigValueEntry GlowAt = new ConfigValueEntry
        {
            Name = "Target",
            MaxValue = Enum.GetValues(typeof(TargetType)).Length - 1,
            MinValue = 0,
            Value = TargetType.Enemy,
            //ValueType = typeof(TargetType),
            IsGrouped = true,
            GroupId = "row1"
        };

        public ConfigValueEntry NeonOutline = new ConfigValueEntry
        {
            Name = "Outline Thickness",
            MaxValue = 20,
            MinValue = 0.1f,
            Incremental = 0.1f,
            Value = 4.3f,
            //ValueType = typeof(float),
            ConvarName = "glow_outline_width",
            ConvarRequire = "Enable",
            IsGrouped = true,
            GroupId = "row2"
        };

        public ConfigValueEntry MaxVelocity = new ConfigValueEntry
        {
            Name = "Movement Only",
            MaxValue = true,
            MinValue = false,
            Value = false,
            //ValueType = typeof(float),
            IsGrouped = true,
            GroupId = "row2"
        };

        public ConfigValueEntry GlowStyle = new ConfigValueEntry
        {
            Name = "Type",
            MaxValue = Enum.GetValues(typeof(GlowRenderStyle_t)).Length - 1,
            MinValue = 0,
            Value = GlowRenderStyle_t.GLOWRENDERSTYLE_DEFAULT,
            //ValueType = typeof(GlowRenderStyle_t),
            IsGrouped = true,
            GroupId = "row3"
        };

        public ConfigValueEntry GlowStyleWhenVisible = new ConfigValueEntry
        {
            Name = "Type Visible",
            MaxValue = Enum.GetValues(typeof(GlowRenderStyle_t)).Length - 1,
            MinValue = 0,
            Value = GlowRenderStyle_t.GLOWRENDERSTYLE_DEFAULT,
            //ValueType = typeof(GlowRenderStyle_t),
            IsGrouped = true,
            GroupId = "row3"
        };
        public ConfigValueEntry AlphaMax = new ConfigValueEntry
        {
            Name = "Alpha Max",
            MaxValue = 1f,
            MinValue = 0f,
            Incremental = 0.01f,
            Value = 1f,
            //ValueType = typeof(float),
            IsGrouped = true,
            GroupId = "row4"
        };
        public ConfigValueEntry FullBloom = new ConfigValueEntry
        {
            Name = "Full Bloom",
            MaxValue = true,
            MinValue = false,
            Value = false,
            //ValueType = typeof(bool),
            IsGrouped = true,
            GroupId = "row4"
        };

        public ConfigValueEntry NeonGlowWeapons = new ConfigValueEntry
        {
            Header = "Other",
            Name = "Weapons",
            MaxValue = true,
            MinValue = false,
            Value = true,
            //ValueType = typeof(bool),
            ConvarName = "mp_weapons_glow_on_ground",
            HiddenFromMenu = false,
            IsGrouped = true,
            GroupId = "row5"
        };
        public ConfigValueEntry NeonGlowGrenades = new ConfigValueEntry
        {
            Name = "Grenades",
            MaxValue = true,
            MinValue = false,
            Value = true,
            //ValueType = typeof(bool),
            IsGrouped = true,
            GroupId = "row5"
        };
        public ConfigValueEntry NeonGlowProjectiles = new ConfigValueEntry
        {
            Name = "Projectiles",
            MaxValue = true,
            MinValue = false,
            Value = true,
            //ValueType = typeof(bool),
            IsGrouped = true,
            GroupId = "row6"
        };
        public ConfigValueEntry NeonGlowDefuse = new ConfigValueEntry
        {
            Name = "Defuse Kits",
            MaxValue = true,
            MinValue = false,
            Value = true,
            //ValueType = typeof(bool),
            IsGrouped = true,
            GroupId = "row6"
        };
        public ConfigValueEntry NeonGlowBomb = new ConfigValueEntry
        {
            Name = "Bomb",
            MaxValue = true,
            MinValue = false,
            Value = true,
            //ValueType = typeof(bool),
            IsGrouped = true,
            GroupId = "row7"
        };
        public ConfigValueEntry NeonGlowChickens = new ConfigValueEntry
        {
            Name = "Chickens",
            MaxValue = true,
            MinValue = false,
            Value = true,
            //ValueType = typeof(bool),
            IsGrouped = true,
            GroupId = "row7"
        };

    }
}
