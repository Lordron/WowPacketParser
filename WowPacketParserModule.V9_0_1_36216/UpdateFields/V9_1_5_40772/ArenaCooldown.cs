using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V9_0_1_36216.UpdateFields.V9_1_5_40772
{
    public class ArenaCooldown : IArenaCooldown
    {
        public System.Nullable<int> SpellID { get; set; }
        public System.Nullable<int> Charges { get; set; }
        public System.Nullable<uint> Flags { get; set; }
        public System.Nullable<uint> StartTime { get; set; }
        public System.Nullable<uint> EndTime { get; set; }
        public System.Nullable<uint> NextChargeTime { get; set; }
        public System.Nullable<byte> MaxCharges { get; set; }
    }
}
