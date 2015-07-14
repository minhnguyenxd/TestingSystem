#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class AtdSummaryViewModel
    {
        public int Id { get; set; }
        //[Display(Name = "Atd Type")]
        public string AtdTypeName { get; set; }
        public string G5Name { get; set; }
        [Display(Name = "Atd S/N")]
        public string AtdSerialNumber { get; set; }

        [Display(Name = "Weight(Kgs)")]
        public decimal? WeightInKgs { get; set; }

        [Display(Name = "Inst. Update")]
        public DateTime? InstrumentationUpdateDate { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsREDue { get; set; }
    }
}