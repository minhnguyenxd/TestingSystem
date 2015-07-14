#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SledISTSignalNameViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please specify the signal name.")]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}