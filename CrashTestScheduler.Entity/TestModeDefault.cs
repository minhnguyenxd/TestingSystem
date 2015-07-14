// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrashTestScheduler.Entity.Model
{
    // TestModeDefault
    public partial class TestModeDefault : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestModeId { get; set; } // TestModeId
        public string TestMode { get; set; } // TestMode
        public string ImpactSide { get; set; } // ImpactSide
        public string ImpactPoint { get; set; } // ImpactPoint
        public string ImpactBarrier { get; set; } // ImpactBarrier
        public decimal? ImpactSpeed { get; set; } // ImpactSpeed
        public decimal? PreferredImpactSpeed { get; set; } // PreferredImpactSpeed
        public decimal? LowLimit { get; set; } // LowLimit
        public decimal? HighLimit { get; set; } // HighLimit
        public string StickerNomenclature { get; set; } // StickerNomenclature
        public bool? RollOver { get; set; } // RollOver
        public decimal? FuelPercent { get; set; } // FuelPercent
        public string FuelTankContents { get; set; } // FuelTankContents
        public string TestWeightMethod { get; set; } // TestWeightMethod
        public bool? ProCam { get; set; } // ProCam
        public bool? Fmvss212WindshieldRetention { get; set; } // FMVSS_212_WindshieldRetention
        public bool? FaroArmReqForDummy { get; set; } // FARO_ArmReqForDummy
        public bool? Fmvss219PartialWindshield { get; set; } // FMVSS_219_PartialWindshield
        public bool? Fmvss219FullWindshield { get; set; } // FMVSS_219_FullWindshield
        public short? Paint { get; set; } // Paint
        public string PaintInstruction { get; set; } // PaintInstruction
        public byte? MoonRoofOpen { get; set; } // MoonRoofOpen
        public bool? WindowsOpen { get; set; } // WindowsOpen
        public string FrontPit { get; set; } // FrontPit
        public string RearPit { get; set; } // RearPit
    }

}
