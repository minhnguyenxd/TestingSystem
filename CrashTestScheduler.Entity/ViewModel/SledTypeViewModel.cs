#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SledTypeViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}