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
    // VehicleLocation
    public partial class VehicleLocation : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public string Description { get; set; } // Description

        // Reverse navigation
        public virtual ICollection<Spot> Spots { get; set; } // Spot.FK_Spot_VehicleLocation
        public virtual ICollection<VehicleRecord> VehicleRecords { get; set; } // VehicleRecord.FK_VehicleRecord_VehicleLocation

        public VehicleLocation()
        {
            Spots = new List<Spot>();
            VehicleRecords = new List<VehicleRecord>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
