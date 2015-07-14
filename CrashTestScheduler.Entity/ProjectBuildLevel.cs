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
    // ProjectBuildLevel
    public partial class ProjectBuildLevel : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int ProjectId { get; set; } // ProjectId
        public int BuildLevelId { get; set; } // BuildLevelId
        public string Name { get; set; } // Name
        public DateTime? StartDate { get; set; } // StartDate
        public DateTime? EndDate { get; set; } // EndDate

        // Foreign keys
        public virtual Project Project { get; set; } // FK_ProjectBuildLevel_Project
    }

}
