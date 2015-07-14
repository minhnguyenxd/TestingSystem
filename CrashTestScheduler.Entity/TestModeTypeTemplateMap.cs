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
    // TestModeTypeTemplateMap
    public partial class TestModeTypeTemplateMap : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestModeId { get; set; } // TestModeId
        public int TestPlanTemplateId { get; set; } // TestPlanTemplateId

        // Foreign keys
        public virtual TestMode TestMode { get; set; } // FK_dbo.TestModeTypeTemplateMap_dbo.TestMode_TestModeId
        public virtual TestPlanTemplate TestPlanTemplate { get; set; } // FK_dbo.TestModeTypeTemplateMap_dbo.TestPlanTemplate_TestPlanTemplateId
    }

}
