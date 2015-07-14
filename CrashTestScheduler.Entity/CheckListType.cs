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
    // CheckListType
    public partial class CheckListType : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<CheckListTypeEmployeeMap> CheckListTypeEmployeeMaps { get; set; } // CheckListTypeEmployeeMap.FK_ChecklistTypeEmployeeMap_CheckListType

        public CheckListType()
        {
            CheckListTypeEmployeeMaps = new List<CheckListTypeEmployeeMap>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
