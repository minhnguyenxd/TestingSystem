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
    // Spot
    public partial class Spot : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string SpotNumber { get; set; } // SpotNumber
        public int VehicleLocationId { get; set; } // VehicleLocationId

        // Reverse navigation
        public virtual ICollection<VehicleRecord> VehicleRecords { get; set; } // VehicleRecord.FK_VehicleRecord_Spot

        // Foreign keys
        public virtual VehicleLocation VehicleLocation { get; set; } // FK_Spot_VehicleLocation

        public Spot()
        {
            VehicleRecords = new List<VehicleRecord>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
