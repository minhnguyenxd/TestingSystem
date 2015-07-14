#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SignalLocationViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Location Name")]
        public string LocationName { get; set; }
        public bool IsDeleted { get; set; }
    }
}