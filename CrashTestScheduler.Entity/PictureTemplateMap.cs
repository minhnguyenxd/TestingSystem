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
    // PictureTemplateMap
    public partial class PictureTemplateMap : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int PictureId { get; set; } // PictureId
        public int TemplateId { get; set; } // TemplateId
        public bool Selected { get; set; } // Selected
        public int? SequenceNumber { get; set; } // SequenceNumber
        public int? Sequenceno { get; set; } // sequenceno

        // Foreign keys
        public virtual Picture Picture { get; set; } // FK_PictureTemplateMap_Picture
        public virtual TestPlanTemplate TestPlanTemplate { get; set; } // FK_PictureTemplateMap_TestPlanTemplate
    }

}
