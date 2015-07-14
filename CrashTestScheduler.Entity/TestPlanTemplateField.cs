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
    // TestPlanTemplateFields
    public partial class TestPlanTemplateField : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestPlanTemplateId { get; set; } // TestPlanTemplateId
        public string FieldName { get; set; } // FieldName
        public bool Selected { get; set; } // Selected

        // Foreign keys
        public virtual TestPlanTemplate TestPlanTemplate { get; set; } // FK_dbo.TestPlanTemplateFields_dbo.TestPlanTemplate_TestPlanTemplateId
    }

}
