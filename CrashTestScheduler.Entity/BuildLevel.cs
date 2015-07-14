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
    // BuildLevel
    public partial class BuildLevel : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public DateTime? StartDate { get; set; } // StartDate
        public DateTime? EndDate { get; set; } // EndDate

        // Reverse navigation
        public virtual ICollection<SledBuck> SledBucks { get; set; } // SledBuck.FK_SledBuck_BuildLevel

        public BuildLevel()
        {
            SledBucks = new List<SledBuck>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
