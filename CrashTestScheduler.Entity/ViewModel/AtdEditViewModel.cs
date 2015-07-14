using CrashTestScheduler.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public enum ImpactDirections
    {
        Omni,
        Left,
        Front,
        Rear,
        Right
    }

    public class AtdEditViewModel
    {
        public int Id { get; set; }

        [Required]
        public int AtdTypeId { get; set; }

        [Required]
        [Display(Name = "G5")]
        public int G5Id { get; set; }

        [Display(Name = "Type")]
        public string AtdTypeName { get; set; }

        [Display(Name = "Serial #")]
        public string AtdSerialNumber { get; set; }

        [Display(Name = "G5")]
        public string G5Name { get; set; }

        [Display(Name = "Channel Count")]
        public int? ChannelCount { get; set; }

        [Required]
        [Display(Name = "Weight(Kgs)")]
        public decimal? WeightInKgs { get; set; }

        [Required]
        [Display(Name = "Calibration due date")]
        public DateTime? InstrumentationUpdateDate { get; set; }

        [Display(Name = "Deleted")]
        public bool IsDeleted { get; set; }

        public List<ImpactDirection> ImpactDirections { get; set; }
    }
}
