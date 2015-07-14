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
    // ComponentsTestResult
    public partial class ComponentsTestResult : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public DateTime? ScheduledTestDate { get; set; } // ScheduledTestDate
        public DateTime? ScheduledCompletedDate { get; set; } // ScheduledCompletedDate
        public string TestNumber { get; set; } // TestNumber
        public int? SequenceNumber { get; set; } // SequenceNumber
        public byte? RequestStatus { get; set; } // RequestStatus

        // Reverse navigation
        public virtual ICollection<ComponentsPostTest> ComponentsPostTests { get; set; } // ComponentsPostTest.FK_ComponentsPostTest_ComponentsTestResult
        public virtual ICollection<ComponentsPreTest> ComponentsPreTests { get; set; } // ComponentsPreTest.FK_ComponentsPreTest_ComponentsTestResult

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_ComponentsTestResult_TestRequest

        public ComponentsTestResult()
        {
            ComponentsPostTests = new List<ComponentsPostTest>();
            ComponentsPreTests = new List<ComponentsPreTest>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
