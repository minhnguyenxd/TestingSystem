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
    // TestRequestVideo
    public partial class TestRequestVideo : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public int VideoId { get; set; } // VideoId
        public string Path { get; set; } // Path
        public bool VideoTaken { get; set; } // VideoTaken
        public string VerifiedBy { get; set; } // VerifiedBy
        public int? IterationId { get; set; } // IterationId

        // Foreign keys
        public virtual SledIteration SledIteration { get; set; } // FK_dbo_TestRequestVideo_SledIteration_IterationId
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.TestRequestVideo_dbo.TestRequest_TestRequestId
        public virtual Video Video { get; set; } // FK_dbo.TestRequestVideo_dbo.Video_VideoId
    }

}
