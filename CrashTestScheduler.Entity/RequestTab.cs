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
    // RequestTabs
    public partial class RequestTab : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public int? LabTypeId { get; set; } // LabTypeId

        // Reverse navigation
        public virtual ICollection<RequestTabState> RequestTabStates { get; set; } // RequestTabState.FK_dbo.RequestTabState_dbo.RequestTabs_Id

        public RequestTab()
        {
            RequestTabStates = new List<RequestTabState>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
