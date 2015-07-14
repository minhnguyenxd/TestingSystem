using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CrashTestScheduler.Entity.Model;


namespace CrashTestScheduler.Entity.ViewModel
{
    public class ChecklistEmployeeViewModel
    {
        public int Id { get; set; }        
        public string EmployeeName { get; set; }              
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; } 
        public string GroupList { get; set; }
    }
}
