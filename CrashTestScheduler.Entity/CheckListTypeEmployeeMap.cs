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
    // CheckListTypeEmployeeMap
    public partial class CheckListTypeEmployeeMap : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int EmployeeId { get; set; } // EmployeeId
        public int ChecklistId { get; set; } // ChecklistId

        // Foreign keys
        public virtual CheckListType CheckListType { get; set; } // FK_ChecklistTypeEmployeeMap_CheckListType
        public virtual Employee Employee { get; set; } // FK_ChecklistTypeEmployeeMap_Employee
    }

}
