using FileHelpers;
using System.ComponentModel.DataAnnotations;

namespace CrashTestScheduler.Entity.Data
{
    public class AtdChannelModelFixed
    {
        public int Id { get; set; }
        public int AtdId { get; set; }
        public string ChannelNumber { get; set; }
        public int AtdChannelLocationId { get; set; }
        public string AtdChannelLocationLocation { get; set; }
        public string ChimChimLocationLocation { get; set; }
        public int ChimChimLocationId { get; set; }
        public string ModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public bool Polarity { get; set; }
        public double? Sensitivity { get; set; }
        public decimal ActualFs { get; set; }
        public decimal DesiredFs { get; set; }
        public string EngUnitName { get; set; }
        public int EngUnitId { get; set; }
        public string BridgeType { get; set; }
        public int SaeClassId { get; set; }
        public string SaeClassName { get; set; }
        public System.DateTime LastCalibrationDate { get; set; }
        public int ReliefColorId { get; set; }
        public string ReliefColorName { get; set; }
        public string CalibrationFixtureNumber { get; set; }
        public bool CalFixtureAvailable { get; set; }
        public string IsoCode { get; set; }
        public string SensorType { get; set; }
        public string Manufacturer { get; set; }
        public string Axis { get; set; }
        public string Dimension { get; set; }
        public decimal? ExcVdc { get; set; }
        public decimal? Output { get; set; }
        public bool OutputProportionalToExc { get; set; }
        public bool UseShuntCal { get; set; }
        public decimal? BridgeResistance { get; set; }
        public decimal? ShuntResistorValues { get; set; }
        public decimal? ShuntResistorEqualentEu { get; set; }
        public bool BypassAaFilter { get; set; }
        public bool RemoveSensorOffset { get; set; }
        public decimal? SensorOffsetLow { get; set; }
        public decimal? SensorOffsetHigh { get; set; }
        public string SoftwareZeroReference { get; set; }
        public decimal? SoftwareZeroEquivalentEu { get; set; }
        public string DallasSensorId { get; set; }
        public string Atdfixgen { get; set; }
        public string HelpfulAuxSorter1 { get; set; }
        public string HelpfulAuxSorter2 { get; set; }
        public string GroupName { get; set; }
        public int ImpactDirectionId { get; set; }
        public string ImpactDirectionName { get; set; }
        public int FilterId { get; set; }
        public string FilterName { get; set; }
        public int? Category { get; set; } // Category
        public decimal? IRtraccLinNumber { get; set; } // IRtraccLinNumber
    }
}
