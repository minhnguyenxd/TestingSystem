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
    // VehicleRecord
    public partial class VehicleRecord : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string VinNumber { get; set; } // VINNumber
        public string VinPicture { get; set; } // VINPicture
        public string EngineVin { get; set; } // EngineVin
        public string EngineVinPicture { get; set; } // EngineVinPicture
        public string EnginePicture { get; set; } // EnginePicture
        public string GoukiNumber { get; set; } // GoukiNumber
        public string SomeNumber { get; set; } // SomeNumber
        public string VehiclePic { get; set; } // VehiclePIC
        public string SidePicture { get; set; } // SidePicture
        public string FrontPicture { get; set; } // FrontPicture
        public int? LocationId { get; set; } // LocationId
        public int? SpotId { get; set; } // SpotId
        public bool IsDestroyed { get; set; } // IsDestroyed
        public bool FuelCert { get; set; } // FuelCert
        public string DrfNumber { get; set; } // DRFNumber
        public DateTime? DestroyedDate { get; set; } // DestroyedDate
        public bool IsDeleted { get; set; } // IsDeleted

        // Foreign keys
        public virtual Spot Spot { get; set; } // FK_VehicleRecord_Spot
        public virtual VehicleLocation VehicleLocation { get; set; } // FK_VehicleRecord_VehicleLocation
    }

}
