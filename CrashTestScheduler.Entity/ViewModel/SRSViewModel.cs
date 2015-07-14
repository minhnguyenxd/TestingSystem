using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SRSViewModel
    {
        public  int Id { get; set; } // Id (Primary key)
         [Required(ErrorMessage = "You must have a name for the new Srs!")]
        public string Name { get; set; } // Name
        public bool IsDeleted { get; set; } // IsDeleted
        [Required(ErrorMessage = "You must choose a left channel!")]
        public string LeftChannel { get; set; }
        public int? LeftChannelId { get; set; } 
        [Required(ErrorMessage = "You must choose a right channel!")]
        public string RightChannel { get; set; }
        public int? RightChannelId { get; set; } 

    }
}
