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
    // ChecklistTemplateMap
    public partial class ChecklistTemplateMap : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int CheckListDataId { get; set; } // CheckListDataId
        public int TemplateId { get; set; } // TemplateId
        public bool Selected { get; set; } // Selected
        public int SequenceNo { get; set; } // SequenceNo

        // Foreign keys
        public virtual ChecklistData ChecklistData { get; set; } // FK_dbo.ChecklistTemplateMap_dbo.ChecklistData_CheckListDataId
        public virtual TestPlanTemplate TestPlanTemplate { get; set; } // FK_ChecklistTemplateMap_TestPlanTemplate1
    }

}
