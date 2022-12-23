using Newtonsoft.Json;
using ResurrectedEternalSkeens.Configs;
using ResurrectedEternalSkeens.Configs.GamePlayConfig;

namespace ResurrectedEternalSkeens
{
    public enum ConfigType
    {
        Generic,
        Colors,
        Convars,
        Mode
    }
    public class ConfigValueEntry
    {
        [JsonIgnore]
        public string AccessorName;
        [JsonIgnore]
        public string Header;
        [JsonIgnore]
        public string Name;
        //public Type ValueType;
        [JsonIgnore]
        public object MaxValue;
        [JsonIgnore]
        public object MinValue;

        public object Value;

        [JsonIgnore]
        public object Incremental = 1.0f;
        [JsonIgnore]
        public string ConvarName;
        [JsonIgnore]
        public string ConvarRequire;
        [JsonIgnore]
        public bool HiddenFromMenu = false;
        [JsonIgnore]
        public object DefaultValue;
        [JsonIgnore]
        public bool IsGrouped = false;
        [JsonIgnore]
        public string GroupId;
        [JsonIgnore]
        public PadStyle PadStyle = PadStyle.Center;
    }

    public enum RadarStyle
    {
        Circular,
        Box
    }
    public enum AimbotStyle
    {
        Pixel,
        Angle,
        HitBox
    }

    public enum TargetType
    {
        Enemy,
        Friendly,
        All
    }

    public enum RCSSmoothType
    {
        None,
        Adaptive,
        Incremental
    }

    public enum SmoothType
    {
        SmoothStep,
        Lerp
    }

    public enum AimPriority
    {
        ClosestToCrosshair,
        DistanceToSelf,

    }
    public enum DrawPosition
    {
        Top,
        Left,
        Right,
        Bottom
    }

    public class Config
    {

        public AimbotConfig AimbotConfig = new AimbotConfig();
        public NeonConfig NeonConfig = new NeonConfig(); 
        public OtherConfig OtherConfig = new OtherConfig();
    }
}