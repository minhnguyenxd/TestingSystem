using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class InstrumentedAtdLegViewModel
    {
        public int Id { get; set; }
        public int AtdTypeId { get; set; }

        [Required(ErrorMessage = "Serial no required")]
        public string SerialNumber { get; set; }

        public bool? IsDeleted { get; set; } // IsDeleted

        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy

        public string AdtTypeName { get; set; }

        public IEnumerable<SelectListItem> AtdTypes { get; set; }
    }
}
