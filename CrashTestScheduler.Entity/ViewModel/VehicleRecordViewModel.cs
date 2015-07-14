using System;
using System.ComponentModel.DataAnnotations;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class VehicleRecordViewModel
    {

        [Display(Name = "VIN")]
        public int VehicleRecordId { get; set; }
        [Required]
        [Display(Name = "VIN Number")]
        public string VinNumber { get; set; }

        [Display(Name = "VIN Picture")]
        public string VinPicture { get; set; }

        [Required]
        [Display(Name = "Engine VIN Number")]
        public string EngineVin { get; set; }

        [Display(Name = "Engine VIN Picture")]
        public string EngineVinPicture { get; set; }

        [Display(Name = "Engine Picture")]
        public string EnginePicture { get; set; }

        [Required]
        [Display(Name = "Gouki Number")]
        public string GoukiNumber { get; set; }

        [Display(Name = "Some Number")]
        public string SomeNumber { get; set; }

        [Display(Name = "Vehicle PIC")]
        public string VehiclePic { get; set; }

        [Display(Name = "Side Picture")]
        public string SidePicture { get; set; }

        [Display(Name = "Front Picture")]
        public string FrontPicture { get; set; }

        [Required]
        [Display(Name = "Location")]
        public int? LocationId { get; set; }

        [Display(Name = "Spot Number")]
        public int? SpotId { get; set; }

        public string VehicleLocationName { get; set; }

        public string SpotSpotNumber { get; set; }

        public string Position
        {
            get
            {
                return (!string.IsNullOrEmpty(SpotSpotNumber) && !string.IsNullOrEmpty(VehicleLocationName)) ? string.Format("{0} - {1}", VehicleLocationName, SpotSpotNumber) : string.Empty;

            }
        }

        [Display(Name = "Is Destroyed")]
        public bool IsDestroyed { get; set; }

        [Display(Name = "Fuel Cert")]
        public bool FuelCert { get; set; }

        [Display(Name = "DRF Number")]
        public string DrfNumber { get; set; }

        [Display(Name = "Destroyed Date")]
        public DateTime? DestroyedDate { get; set; }

        [Display(Name = "IsDeleted")]
        public bool IsDeleted { get; set; }

        public string DeletedPictureType { get; set; }
        
    }
}
