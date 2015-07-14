using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; } // Id (Primary key)
        public string FullName { get; set; } // FirstName
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } // FirstName
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } // LastName
        public string MiddleName { get; set; } // MiddleName
        [Required(ErrorMessage = "User name is required")]
        public string SamAccountName { get; set; }// Sam account name
        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; } // PhoneNumber
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }
        public List<ChecklistTypeViewModel> ChecklistType { get; set; }
        public string GroupList { get; set; }
    }

}
