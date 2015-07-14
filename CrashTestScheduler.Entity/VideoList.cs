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
    // VideoList
    public partial class VideoList : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestTypeId { get; set; } // TestTypeId
        public int VideoId { get; set; } // VideoId

        // Foreign keys
        public virtual TestType TestType { get; set; } // FK_dbo.VideoList_dbo.TestType_TestTypeId
        public virtual Video Video { get; set; } // FK_dbo.VideoList_dbo.Video_VideoId
    }

}
