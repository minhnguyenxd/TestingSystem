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
    // G5
    public partial class G5 : EntityBase
    {
        public override  int Id { get; set; } // ID (Primary key)
        public string Name { get; set; } // Name
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy

        // Reverse navigation
        public virtual ICollection<Atd> Atds { get; set; } // Atd.FK_dbo.Atd_dbo.G5_G5Id
        public virtual ICollection<TestRequestDummy> TestRequestDummies { get; set; } // TestRequestDummy.FK_dbo.TestRequestDummy_dbo.G5_G5Id

        public G5()
        {
            Atds = new List<Atd>();
            TestRequestDummies = new List<TestRequestDummy>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
