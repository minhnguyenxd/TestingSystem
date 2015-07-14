using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class UserViewModel
    {
        // UserName is same as SamAccountName
        public string UserName { get; set; }
        public string FirstName { get; set; } // FirstName
        public string LastName { get; set; } // LastName
        public string MiddleName { get; set; } // MiddleName
        public string EmailAddress { get; set; } // EmailAddress
        public string PhoneNumber { get; set; } // PhoneNumber
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? CreatedDate { get; set; } // CreatedDate
        public DateTime? ModifiedDate { get; set; } // ModifiedDate
        public string ManagerSamAccountName { get; set; } // ManagerSamAccountName

        public string Role { get; set; }
        
        public string DisplayName { get; set; }
        public string ChecklistInitial { get; set; }
        public bool? IsIterationOperator { get; set; }

    }
}
