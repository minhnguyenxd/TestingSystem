using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CrashTestScheduler.Entity.Model;

namespace CrashTestScheduler.Entity.ViewModel
{
    public enum EventType
    {
        PM,
        repair,
        Cal,
        Other
    }

    public class EquipmentEventViewModel : IInput
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        [Required]
        [Display(Name = "Event Type")]
        public int EventType { get; set; }
        [Required]
        [Display(Name = "Comments")]
        public string Comments { get; set; }
        [Required]
        [Display(Name = "Event Date")]
        public DateTime EventDate { get; set; }
        public string Attachment { get; set; }
        public bool IsActive { get; set; }
    }
}
