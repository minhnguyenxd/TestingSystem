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
    // IrlTestRequest
    public partial class IrlTestRequest : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? TestRequestId { get; set; } // TestRequestId
        public int? NoOfTestSeries { get; set; } // NoOfTestSeries
        public int? NoOfACtualSeries { get; set; } // NoOfACtualSeries
        public int? RequiredBlock { get; set; } // RequiredBlock
        public int? ActualBlock { get; set; } // ActualBlock
        public int? TestType { get; set; } // TestType
        public int? Uut { get; set; } // Uut

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.IrlTestRequest_dbo.TestRequest_TestRequestId
    }

}
