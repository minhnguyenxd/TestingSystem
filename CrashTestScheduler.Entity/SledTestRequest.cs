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
    // SledTestRequest
    public partial class SledTestRequest : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? TestRequestId { get; set; } // TestRequestId
        public bool? IsOffSiteLabe { get; set; } // IsOffSiteLabe
        public int? SledTypeId { get; set; } // SledTypeId
        public int? BuckId { get; set; } // BuckId
        public int? TestType { get; set; } // TestType
        public bool? SignalIteration { get; set; } // SignalIteration
        public int? NoOfTestSeries { get; set; } // NoOfTestSeries
        public int? NoOfACtualSeries { get; set; } // NoOfACtualSeries
        public int? RequiredBlock { get; set; } // RequiredBlock
        public int? ActualBlock { get; set; } // ActualBlock
        public int? NoOfSignals { get; set; } // NoOfSignals
        public int? BuildLevelId { get; set; } // BuildLevelId

        // Foreign keys
        public virtual SledBuck SledBuck { get; set; } // FK_dbo.SledTestRequest_dbo.SledBuck_BuckId
        public virtual SledType SledType { get; set; } // FK_dbo.SledTestRequest_dbo.SledType_SledTypeId
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.SledTestRequest_dbo.TestRequest_TestRequestId
    }

}
