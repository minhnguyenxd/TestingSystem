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
    // VideoTestTypeMap
    public partial class VideoTestTypeMap : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int VideoId { get; set; } // VideoId
        public int TestTypeId { get; set; } // TestTypeId

        // Foreign keys
        public virtual TestType TestType { get; set; } // FK_dbo.VideoTestTypeMap_dbo.TestType_TestTypeId
        public virtual Video Video { get; set; } // FK_dbo.VideoTestTypeMap_dbo.Video_VideoId
    }

}
