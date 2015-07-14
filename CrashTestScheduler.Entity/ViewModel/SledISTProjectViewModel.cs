#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SledISTProjectViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please specify the project name.")]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}