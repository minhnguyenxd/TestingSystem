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
    // RequestTabState
    public partial class RequestTabState : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public int TabId { get; set; } // TabId
        public bool Completed { get; set; } // Completed
        public string CompletedBy { get; set; } // CompletedBy

        // Foreign keys
        public virtual RequestTab RequestTab { get; set; } // FK_dbo.RequestTabState_dbo.RequestTabs_Id
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.RequestTabState_dbo.TestRequest_TestRequestId
    }

}
