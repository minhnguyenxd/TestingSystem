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
    // Notifications
    public partial class Notification : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public string Reason { get; set; } // Reason
        public string Recipient { get; set; } // Recipient
        public DateTime DateSent { get; set; } // DateSent

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_Notifications_TestRequest
    }

}
