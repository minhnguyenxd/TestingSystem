#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class AtdUsageEditViewModel
    {
        public int Id { get; set; }
        public int AtdId { get; set; }
        
        [Required]
        [Display(Name = "Evaluation Date")]
        public DateTime TrackDate { get; set; }
        
        [Display(Name = "Eng")]
        public string Eng { get; set; }

        [Required]
        [Display(Name = "Evaluated By")]
        public string TrackBy { get; set; }
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Select a test type.")]
        [Display(Name = "Test Type")]
        public int? CalendarTypeId { get; set; }
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Select an evaluation type.")]
        [Display(Name = "Evaluation Type")]
        public int? EvaluationTypeId { get; set; }
        
        [Display(Name = "Failed Channel")]
        public bool IsFailedChannel { get; set; }
        
        [Required]
        [Display(Name = "General Comment")]
        public string GeneralComments { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Not a valid test request id.")]
        [Display(Name = "Test Request Id")]
        public int? TestRequestId { get; set; }

        [Display(Name = "Inspection/Evaluation Completed")]
        public bool IsVerified { get; set; }

        [Display(Name = "Usage Point")]
        public int? UsagePoint { get; set; }
    }
}