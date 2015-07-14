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
    // BumperPendulumHit
    public partial class BumperPendulumHit : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public int? HitNo { get; set; } // HitNo
        public string TestSubMode { get; set; } // TestSubMode
        public string ImpactLocation { get; set; } // ImpactLocation
        public decimal? VehicleWeightFront { get; set; } // VehicleWeightFront
        public decimal? VehicleWeightRear { get; set; } // VehicleWeightRear
        public decimal? PendulumWeight { get; set; } // PendulumWeight
        public decimal? TargetSpeed { get; set; } // TargetSpeed
        public decimal? ActualSpeedCh1 { get; set; } // ActualSpeedCH1
        public decimal? ActualSpeedCh2 { get; set; } // ActualSpeedCH2
        public decimal? InitialHeight { get; set; } // InitialHeight
        public DateTime CreatedDate { get; set; } // CreatedDate
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string UpdatedBy { get; set; } // UpdatedBy

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_BumperPendulumHit_TestRequest
    }

}
