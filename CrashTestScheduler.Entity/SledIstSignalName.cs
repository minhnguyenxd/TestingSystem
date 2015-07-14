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
    // SledISTSignalName
    public partial class SledIstSignalName : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy

        // Reverse navigation
        public virtual ICollection<SledResult> SledResults { get; set; } // SledResult.FK_dbo_SledResult_SledISTSignalProject_ISTSingalID

        public SledIstSignalName()
        {
            SledResults = new List<SledResult>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
