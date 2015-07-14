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
    // SRSTestPlanMap
    public partial class SrsTestPlanMap : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public int SrsId { get; set; } // SRSId
        public string LeftTtf { get; set; } // LeftTTF
        public bool LeftPickup { get; set; } // LeftPickup
        public bool LeftSquib { get; set; } // LeftSquib
        public string RightTtf { get; set; } // RightTTF
        public bool RightPickup { get; set; } // RightPickup
        public bool RightSquib { get; set; } // RightSquib
        public bool IsActive { get; set; } // IsActive
        public bool? Verified { get; set; } // Verified
        public string VerifyerName { get; set; } // VerifyerName

        // Foreign keys
        public virtual SrsSetting SrsSetting { get; set; } // FK_SRSTestPlanMap_SRSSetting
        public virtual TestRequest TestRequest { get; set; } // FK_SRSTestPlanMap_TestRequest
    }

}
