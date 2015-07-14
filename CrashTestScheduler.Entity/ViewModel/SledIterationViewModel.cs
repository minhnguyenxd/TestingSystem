#region

using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Humanizer;
using model = CrashTestScheduler.Entity.Model;
#endregion

namespace CrashTestScheduler.Entity.ViewModel
{

    public class SledIterationViewModel
    {
        [Display(Name = "Request Status")]
        public int RequestStatus { get; set; }

        public DateTime ScheduledTestDate { get; set; }
        public DateTime ScheduledCompletedDate { get; set; }
        public int? SequenceNumber { get; set; }
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public bool IsIteration { get; set; }
        public int Count { get; set; }
        public int SledTypeId { get; set; }
        public string Title { get; set; }
        public string FrameCode { get; set; }
        public string IterationType { get; set; }
        public String RequestStatusDisplayName
        {
            get
            {
                return ((model.RequestStatus)RequestStatus).Humanize();
            }
        }
        public bool IsCompleted { get; set; }
        public IrlTestPlanViewModel TestPlan { get; set; }
        public string TestNumber { get; set; }
        public List<SledPulseInfoViewModel> SledPulseInfoDetails { get; set; }
        public List<SledPositionViewModel> SledPositionDetails { get; set; }
        public List<SledAtdInfoViewModel> SledAtdInfoDetails { get; set; }
        public SledResultViewModel SledResultInfoDetails { get; set; }
        public SledIterationViewModel()
        {
            SledPulseInfoDetails = new List<SledPulseInfoViewModel>();
            SledPositionDetails = new List<SledPositionViewModel>();
            SledAtdInfoDetails = new List<SledAtdInfoViewModel>();
        }

    }

 

}