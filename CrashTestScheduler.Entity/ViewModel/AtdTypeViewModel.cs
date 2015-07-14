using System;
using System.ComponentModel.DataAnnotations;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class AtdTypeViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be empty")]
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsDeleted	{get;set;}

        public DateTime DeletedDate	{get;set;}

        public String DeletedBy {get;set;}

        public bool IsBallast { get; set; }
        
    }
}
