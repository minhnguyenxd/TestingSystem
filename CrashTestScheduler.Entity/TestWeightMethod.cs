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
    // TestWeightMethod
    public partial class TestWeightMethod : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<TestPlanTemplate> TestPlanTemplates { get; set; } // TestPlanTemplate.FK_TestPlanTemplate_TestWeightMethod

        public TestWeightMethod()
        {
            TestPlanTemplates = new List<TestPlanTemplate>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
