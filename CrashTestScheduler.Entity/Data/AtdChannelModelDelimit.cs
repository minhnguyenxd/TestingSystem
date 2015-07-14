using System;
using FileHelpers;

namespace CrashTestScheduler.Entity.Data
{
    [DelimitedRecord(",")]
    public class AtdChannelModelDelimit
    {
        public string Ref= string.Empty;
        public string SerialNumber= string.Empty;
        public string ChimChimLocationLocation= string.Empty;
        public string AtdChannelLocationLocation= string.Empty;
        public string CalibrationFixtureNumber= string.Empty;
        public string CalFixtureAvailable= string.Empty;
        public string IsoCode= string.Empty;
        public string ReliefColorName= string.Empty;
        public string SensorType= string.Empty;
        public string Manufacturer= string.Empty;
        public string ModelNumber= string.Empty;
        public string Axis= string.Empty;
        public string Dimension= string.Empty;
        public string EngUnitName= string.Empty;
        public string ActualFs= string.Empty;
        public string ExcVdc= string.Empty;
        public string Output= string.Empty;
        // If Sensitivity is not specified, it will have a value of 1.0
        // Which would work as avolt meter.
        public double Sensitivity = 1.0;
        public string OutputProportionalToExc= string.Empty;
        public string DesiredFs= string.Empty;
        public string BridgeType= string.Empty;
        public string UseShuntCal= string.Empty;
        public string BridgeResistance= string.Empty;
        public string ShuntResistorValues= string.Empty;
        public string ShuntResistorEqualentEu= string.Empty;
        public string BypassAaFilter= string.Empty;
        public string Polarity= string.Empty;
        public string RemoveSensorOffset= string.Empty;
        public string SensorOffsetLow= string.Empty;
        public string SensorOffsetHigh= string.Empty;
        public string SaeClassName= string.Empty;
        public string SoftwareZeroReference= string.Empty;
        public string SoftwareZeroEquivalentEu= string.Empty;
        public string DallasSensorId= string.Empty;
        public string Atdfixgen= string.Empty;
        [FieldConverter(ConverterKind.Date, "MM/dd/yyyy")]
        public DateTime LastCalibrationDate;
        public string HelpfulAuxSorter1= string.Empty;
        public string HelpfulAuxSorter2= string.Empty;
        public string ChannelNumber= string.Empty;
        public string GroupName= string.Empty;
        public string Empty1= string.Empty;
        public string Empty2= string.Empty;
        public string Empty3= string.Empty;
        public string Empty4= string.Empty;
        // Category of 0 is Normal
        public int Category;
        public string IRtraccLinNumber= string.Empty;



    }
}
