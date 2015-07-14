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
    // ComponentsTestRequest
    public partial class ComponentsTestRequest : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? TestRequestId { get; set; } // TestRequestId
        public int? RequiredBlock { get; set; } // RequiredBlock
        public int? ActualBlock { get; set; } // ActualBlock
        public int? TestType { get; set; } // TestType
        public int? TestPurposeId { get; set; } // TestPurposeId
        public int? DevelopmentStageId { get; set; } // DevelopmentStageId
        public int? NoOfTestSeries { get; set; } // NoOfTestSeries

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.ComponentsTestRequest_dbo.TestRequest_TestRequestId
    }

}
