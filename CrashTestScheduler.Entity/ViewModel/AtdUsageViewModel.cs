#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class AtdUsageViewModel
    {
        public int Id { get; set; }
        public int AtdId { get; set; }
        [Display(Name = "Evaluation Date")]
        public DateTime TrackDate { get; set; }
        [Display(Name = "Eng")]
        public string Eng { get; set; }
        [Display(Name = "Evaluated By")]
        public string TrackBy { get; set; }
        [Display(Name = "Test Type")]
        public string CalendarTypeName { get; set; }
        [Display(Name = "Evaluation Type")]
        public string EvaluationTypeName { get; set; }
        [Display(Name = "Failed Channel")]
        public bool IsFailedChannel { get; set; }
        [Display(Name = "General Comment")]
        public string GeneralComments { get; set; }
        [Display(Name = "Test Request Id")]
        public int? TestRequestId { get; set; }
        [Display(Name = "Verified")]
        public bool IsVerified { get; set; }
        [Display(Name = "Usage Point")]
        public int? UsagePoint { get; set; }
        public int SerialNo { get; set; }
    }
}