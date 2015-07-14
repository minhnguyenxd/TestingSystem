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
    // TestLaboratory
    public partial class TestLaboratory : EntityBase
    {
        public string Name { get; set; } // Name
        public string Location { get; set; } // Location
        public bool Active { get; set; } // Active
        public bool? OpenOnWeekend { get; set; } // OpenOnWeekend
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy
        public DateTime CreatedDate { get; set; } // CreatedDate
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string UpdatedBy { get; set; } // UpdatedBy
        public int? CalendarTypeId { get; set; } // CalendarTypeId
        public override  int Id { get; set; } // id (Primary key)

        // Reverse navigation
        public virtual ICollection<TestRequest> TestRequests { get; set; } // TestRequest.FK_TestRequest_TestLaboratory_num

        // Foreign keys
        public virtual CalendarType CalendarType { get; set; } // FK_TestLaboratory_CalendarType_num

        public TestLaboratory()
        {
            TestRequests = new List<TestRequest>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
