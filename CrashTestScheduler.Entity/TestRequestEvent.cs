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
    // TestRequestEvent
    public partial class TestRequestEvent : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public int EventType { get; set; } // EventType
        public DateTime Date { get; set; } // Date
        public bool ShowInCalendar { get; set; } // ShowInCalendar

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.TestRequestEvent_dbo.TestRequest_TestRequestId
    }

}
