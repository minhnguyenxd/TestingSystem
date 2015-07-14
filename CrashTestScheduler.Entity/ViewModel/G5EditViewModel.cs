using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    
    public class G5EditViewModel
    {
        public int Id { get; set; }
        
        [Display(Name="Name")]
        public string Name { get; set; }

        //[Display(Name = "Deleted")]
        public bool IsDeleted { get; set; }

    }
}
