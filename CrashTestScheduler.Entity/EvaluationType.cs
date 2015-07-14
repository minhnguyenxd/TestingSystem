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
    // EvaluationType
    public partial class EvaluationType : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Code { get; set; } // Code
        public string Name { get; set; } // Name
        public string Description { get; set; } // Description

        // Reverse navigation
        public virtual ICollection<AtdUsage> AtdUsages { get; set; } // AtdUsage.FK_AtdUsage_EvaluationType

        public EvaluationType()
        {
            AtdUsages = new List<AtdUsage>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
