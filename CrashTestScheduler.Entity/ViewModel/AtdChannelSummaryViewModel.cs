using System.ComponentModel.DataAnnotations;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class AtdChannelSummaryViewModel
    {
        public int Id { get; set; }
        public int AtdId { get; set; }
        [Required]
        [Display(Name = "CH #")]
        public string ChannelNumber { get; set; }
        [Display(Name = "LocationId")]
        public int AtdChannelLocationId { get; set; }
        [Display(Name = "Location")]
        public string AtdChannelLocationLocation { get; set; }
        [Display(Name = "ChimChim Name")]
        public string ChimChimLocationLocation { get; set; }
        [Display(Name = "Chim Chim Id")]
        public int ChimChimLocationId { get; set; }
        [Required]
        [Display(Name = "Model #")]
        public string ModelNumber { get; set; }
        [Required]
        [Display(Name = "Serial #")]
        public string SerialNumber { get; set; }

        public bool Polarity { get; set; }
        [Required]
        public double? Sensitivity { get; set; }
        [Required]
        public decimal ActualFs { get; set; }
        [Required]
        public decimal DesiredFs { get; set; }
        [Display(Name = "Eng Unit")]
        public string EngUnitName { get; set; }
        [Required]
        public int EngUnitId { get; set; }
        [Required]
        [Display(Name = "Bridge Type")]
        public string BridgeType { get; set; }
				
        [Required]
        public int SaeClassId { get; set; }
		[Display(Name = "SAE Class")]
		public string SaeClassName { get; set; }

        [Required]
        [Display(Name = "Calibration due date")]
        public System.DateTime? LastCalibrationDate { get; set; }

        [Required]
        public int ReliefColorId { get; set; }
        [Display(Name = "Relief Color")]
        public string ReliefColorName { get; set; }

        // Additional Properties
        [Display(Name = "Calibration Fixture Number")]
        public string CalibrationFixtureNumber { get; set; }

        [Display(Name = "Calibration Fixture Available")]
        public bool CalFixtureAvailable { get; set; }

        [Display(Name = "ISO Code")]
        public string IsoCode { get; set; }

        [Display(Name = "Sensor Type")]
        public string SensorType { get; set; }

        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }

        [Display(Name = "Axis")]
        public string Axis { get; set; }

        [Display(Name = "Dimension")]
        public string Dimension { get; set; }

        [Display(Name = "Exc Vdc")]
        public decimal? ExcVdc { get; set; }

        [Display(Name = "Output")]
        public decimal? Output { get; set; }

        [Display(Name = "Output Proportional To Exc")]
        public bool OutputProportionalToExc { get; set; }

        [Display(Name = "Use Shunt Cal")]
        public bool UseShuntCal { get; set; }

        [Display(Name = "Bridge Resistance")]
        public decimal? BridgeResistance { get; set; }

        [Display(Name = "Shunt Resistor Values")]
        public decimal? ShuntResistorValues { get; set; }

        [Display(Name = "Shunt Resistor Equivalent Eu")]
        public decimal? ShuntResistorEqualentEu { get; set; }

        [Display(Name = "Bypass Aa Filter")]
        public bool BypassAaFilter { get; set; }

        [Display(Name = "Remove Sensor Offset")]
        public bool RemoveSensorOffset { get; set; }

        [Display(Name = "Sensor Offset Low")]
        public decimal? SensorOffsetLow { get; set; }

        [Display(Name = "Sensor Offset High")]
        public decimal? SensorOffsetHigh { get; set; }

        [Display(Name = "Software Zero Reference")]
        public string SoftwareZeroReference { get; set; }

        [Display(Name = "Software Zero Equivalent Eu")]
        public decimal? SoftwareZeroEquivalentEu { get; set; }

        [Display(Name = "Dallas Sensor Id")]
        public string DallasSensorId { get; set; }

        [Display(Name = "Atd fixgen")]
        public string Atdfixgen { get; set; }

        [Display(Name = "Helpful Aux Sorter1")]
        public string HelpfulAuxSorter1 { get; set; }

        [Display(Name = "Helpful Aux Sorter2")]
        public string HelpfulAuxSorter2 { get; set; }

        [Display(Name = "Group Name")]
        public string GroupName { get; set; }

        public int ImpactDirectionId { get; set; }

        [Display(Name = "Impact Direction")]
        public string ImpactDirectionName { get; set; }

        public int FilterId { get; set; }

        [Display(Name = "Filter")]
        public string FilterName { get; set; }

        [Display(Name = "Category")]
        public int? Category { get; set; } // Category

        [Display(Name = "IRtraccLinNumber")]
        public decimal? IRtraccLinNumber { get; set; } // IRtraccLinNumber

    }
}
