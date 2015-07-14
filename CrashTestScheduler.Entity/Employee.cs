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
    // Employee
    public partial class Employee : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string EmployeeNumber { get; set; } // EmployeeNumber
        public string SamAccountName { get; set; } // SamAccountName
        public string FirstName { get; set; } // FirstName
        public string LastName { get; set; } // LastName
        public string MiddleName { get; set; } // MiddleName
        public string EmailAddress { get; set; } // EmailAddress
        public string PhoneNumber { get; set; } // PhoneNumber
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? CreatedDate { get; set; } // CreatedDate
        public DateTime? ModifiedDate { get; set; } // ModifiedDate
        public string ManagerSamAccountName { get; set; } // ManagerSamAccountName

        // Reverse navigation
        public virtual ICollection<CheckListTypeEmployeeMap> CheckListTypeEmployeeMaps { get; set; } // CheckListTypeEmployeeMap.FK_ChecklistTypeEmployeeMap_Employee

        public Employee()
        {
            CheckListTypeEmployeeMaps = new List<CheckListTypeEmployeeMap>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
