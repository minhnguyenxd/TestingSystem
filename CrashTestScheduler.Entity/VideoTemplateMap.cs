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
    // VideoTemplateMap
    public partial class VideoTemplateMap : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TemplateId { get; set; } // TemplateId
        public bool Selected { get; set; } // Selected
        public int VideoId { get; set; } // VideoId

        // Foreign keys
        public virtual TestPlanTemplate TestPlanTemplate { get; set; } // FK_dbo.VideoTemplateMap_dbo.TestPlanTemplate_TemplateId
        public virtual Video Video { get; set; } // FK_dbo.VideoTemplateMap_dbo.Video_VideoId
    }

}
