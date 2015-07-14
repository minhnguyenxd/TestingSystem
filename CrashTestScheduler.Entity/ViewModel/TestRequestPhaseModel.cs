#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class TestRequestPhaseModel
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        [Display(Name = "Calendar Type")]
        public int CalendarTypeId { get; set; }
        public string CalendarType { get; set; }
    }
}