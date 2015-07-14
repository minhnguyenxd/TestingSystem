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
    // CalendarType
    public partial class CalendarType : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<AtdUsage> AtdUsages { get; set; } // AtdUsage.FK_AtdUsage_CalendarType
        public virtual ICollection<TestLaboratory> TestLaboratories { get; set; } // TestLaboratory.FK_TestLaboratory_CalendarType_num
        public virtual ICollection<TestRequest> TestRequests { get; set; } // TestRequest.FK_dbo.TestRequest_dbo.CalendarType_CalendarTypeId
        public virtual ICollection<TestRequestPhase> TestRequestPhases { get; set; } // TestRequestPhase.FK_dbo.TestRequestPhase_dbo.CalendarType_CalendarTypeId
        public virtual ICollection<TestType> TestTypes { get; set; } // TestType.FK_TestType_CalendarType

        public CalendarType()
        {
            AtdUsages = new List<AtdUsage>();
            TestLaboratories = new List<TestLaboratory>();
            TestRequests = new List<TestRequest>();
            TestRequestPhases = new List<TestRequestPhase>();
            TestTypes = new List<TestType>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
