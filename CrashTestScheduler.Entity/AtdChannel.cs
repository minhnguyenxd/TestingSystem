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
    // AtdChannel
    public partial class AtdChannel : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? AtdId { get; set; } // AtdId
        public string ChannelNumber { get; set; } // ChannelNumber
        public int? AtdChannelLocationId { get; set; } // AtdChannelLocationId
        public int? ChimChimLocationId { get; set; } // ChimChimLocationId
        public string ModelNumber { get; set; } // ModelNumber
        public string SerialNumber { get; set; } // SerialNumber
        public bool? Polarity { get; set; } // Polarity
        public double? Sensitivity { get; set; } // Sensitivity
        public int? ReliefColorId { get; set; } // ReliefColorId
        public decimal? ActualFs { get; set; } // ActualFS
        public decimal? DesiredFs { get; set; } // DesiredFS
        public string BridgeType { get; set; } // BridgeType
        public int? SaeClassId { get; set; } // SaeClassId
        public int? EngUnitId { get; set; } // EngUnitId
        public DateTime? LastCalibrationDate { get; set; } // LastCalibrationDate
        public string CalibrationFixtureNumber { get; set; } // CalibrationFixtureNumber
        public bool? CalFixtureAvailable { get; set; } // CalFixtureAvailable
        public string IsoCode { get; set; } // ISOCode
        public string SensorType { get; set; } // SensorType
        public string Manufacturer { get; set; } // Manufacturer
        public string Axis { get; set; } // Axis
        public string Dimension { get; set; } // Dimension
        public decimal? FullScaleEu { get; set; } // FullScaleEU
        public decimal? ExcVdc { get; set; } // ExcVDC
        public decimal? Output { get; set; } // Output
        public bool? OutputProportionalToExc { get; set; } // OutputProportionalToExc
        public decimal? EuDesiredRange { get; set; } // EUDesiredRange
        public bool? UseShuntCal { get; set; } // UseShuntCal
        public decimal? BridgeResistance { get; set; } // BridgeResistance
        public decimal? ShuntResistorValues { get; set; } // ShuntResistorValues
        public decimal? ShuntResistorEqualentEu { get; set; } // ShuntResistorEqualentEU
        public bool? BypassAaFilter { get; set; } // BypassAAFilter
        public bool? RemoveSensorOffset { get; set; } // RemoveSensorOffset
        public decimal? SensorOffsetLow { get; set; } // SensorOffsetLow
        public decimal? SensorOffsetHigh { get; set; } // SensorOffsetHigh
        public string SoftwareZeroReference { get; set; } // SoftwareZeroReference
        public decimal? SoftwareZeroEquivalentEu { get; set; } // SoftwareZeroEquivalentEU
        public string DallasSensorId { get; set; } // DallasSensorID
        public string Atdfixgen { get; set; } // ATDFIXGEN
        public DateTime? LastCal { get; set; } // LastCal
        public string HelpfulAuxSorter1 { get; set; } // HelpfulAuxSorter1
        public string HelpfulAuxSorter2 { get; set; } // HelpfulAuxSorter2
        public string GroupName { get; set; } // GroupName
        public int? ImpactDirectionId { get; set; } // ImpactDirectionId
        public int? FilterId { get; set; } // FilterId
        public int? Category { get; set; } // Category
        public decimal? IRtraccLinNumber { get; set; } // IRtraccLinNumber

        // Foreign keys
        public virtual Atd Atd { get; set; } // FK_dbo.AtdChannel_dbo.Atd_AtdId
        public virtual AtdChannelLocation AtdChannelLocation { get; set; } // FK_dbo.AtdChannel_dbo.AtdChannelLocation_AtdChannelLocationId
        public virtual ChimChimLocation ChimChimLocation { get; set; } // FK_dbo.AtdChannel_dbo.ChimChimLocation_ChimChimLocationId
        public virtual EngUnit EngUnit { get; set; } // FK_dbo.AtdChannel_dbo.EngUnit_EngUnitId
        public virtual Filter Filter { get; set; } // FK_AtdChannel_Filter
        public virtual ImpactDirection ImpactDirection { get; set; } // FK_AtdChannel_ImpactDirection
        public virtual ReliefColor ReliefColor { get; set; } // FK_dbo.AtdChannel_dbo.ReliefColor_ReliefColorId
        public virtual SaeClass SaeClass { get; set; } // FK_dbo.AtdChannel_dbo.SaeClass_SaeClassId
    }

}
