#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ReliefColorViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please specify the color name.")]
        public string Name { get; set; }
    }
}
