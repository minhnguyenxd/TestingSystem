#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Humanizer;
using model = CrashTestScheduler.Entity.Model;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
}


namespace CrashTestScheduler.Entity.ViewModel
{
    public class IrlTestViewModel
    {
        public IrlTestViewModel()
        {
            signalData = new List<SledSignalViewModel>();
        }
        public int Id { get; set; }

        public int CalendarTypeId { get; set; }

        public SledTestPlanDetailViewModel SledTestPlan { get; set; }
        public List<RequestTabStateViewModel> TabState { get; set; }

        public List<SledSignalViewModel> signalData { get; set; }

        [Display(Name = "Requested Date")]
        [Required(ErrorMessage = "Requested test date is required")]
        public DateTime RequestedTestDate { get; set; }

        [Display(Name = "Scheduled Date")]
        public DateTime? ScheduledTestDate { get; set; }

        [Display(Name = "Change Request Date")]
        public DateTime? ChangeRequestDate { get; set; }

        [Display(Name = "Reschedule Date")]
        public DateTime? RescheduleDate { get; set; }

        [Display(Name = "Test Date")]
        public string TestDate { get; set; }

        [Display(Name = "Test Number")]
        public string TestNumber { get; set; }

        [Display(Name = "PIC Name")]
        public string PicName { get; set; }

        [Display(Name = "Sensor Picture")]
        public string SensorPic { get; set; }

        [Display(Name = "PTC Approver")]
        public string PtcApprover { get; set; }


        [Display(Name = "PIC Name")]
        [Required]
        public string PicDisplayName { get; set; }

        [Display(Name = "Sensor PIC Name")]
        [Required]
        public string SensorPicDisplayName { get; set; }

        [Display(Name = "PTC Approver")]
        public string PtcApproverDisplayName { get; set; }

        [Display(Name = "PIC Phone")]
        [Required]
        public string PicPhone { get; set; }

        [Display(Name = "Sensor PIC Phone")]
        [Required]
        public string SensorPicPhone { get; set; }

        [Display(Name = "PTC Approver Phone")]
        public string PtcApproverPhone { get; set; }

        [Display(Name = "Comments")]
        public string Comment { get; set; }

         

        [Display(Name = "Scheduled By")]
        public string ScheduledBy { get; set; }

        [Display(Name = "Request Status")]
        public int RequestStatus { get; set; }

        public String RequestStatusDisplayName
        {
            get
            {
                return ((model.RequestStatus)RequestStatus).Humanize();
            }
        }

        [Display(Name = "Approved By")]
        public string ApprovedBy { get; set; }

        [Display(Name = "Approved Date")]
        public string ApprovedDate { get; set; }

        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        [Required]
        [Display(Name = "Project")]
        [Range(1, int.MaxValue, ErrorMessage = "Please choose a project.")]
        public int? ProjectId { get; set; }

        [Required]
        [Display(Name = "Build Level")]
        [Range(1, int.MaxValue, ErrorMessage = "Please choose build level.")]
        public int? BuildLevelId { get; set; }

        
        [Display(Name = "Frame Code")]
        public string FrameCode { get; set; }

        public List<UserViewModel> TestTechLeads { get; set; }


        [Required]
        [Display(Name = "Iterations Required")]
        public bool SignalIteration { get; set; }

        [Required]
        [Display(Name = "Test Laboratory")]
        public int? TestLaboratoryId { get; set; }

        [Display(Name = "Laboratory Name")]
        public string TestLaboratoryName { get; set; }

        public bool? HasTemplate { get; set; }

        [Required]
        [Display(Name = "Test Type")]
        [Range(1, int.MaxValue, ErrorMessage = "Please choose a Test type.")]
        public int? TestTypeId { get; set; }

        [Required]
        [Display(Name = "UUT")]
        [Range(1, int.MaxValue, ErrorMessage = "Please choose a UUT.")]
        public int? UutId { get; set; }

        [Display(Name = "Number Of Signals to be Iterated")]
        public int NoOfSingalLocation { get; set; }

        [Display(Name = "# Of Test In Series")]
        [Range(1, int.MaxValue, ErrorMessage = "# Of Test should be more than 0.")]
        public int NoOfTestSeries { get; set; }

        [Display(Name = "Blocks Required")]
        public int BlockReq { get; set; }

        [Display(Name = "Actual Block")]
        public int ActuralBlock { get; set; }

        [Required]
        [Display(Name = "Test Mode")]
        [Range(1, int.MaxValue, ErrorMessage = "Please choose a Test mode.")]
        public int? TestModeId { get; set; }

        [Display(Name = "Test Type")]
        public string TestTypeName { get; set; }

        [Display(Name = "Test Mode")]
        public string TestModeName { get; set; }

        [Display(Name = "Test Plan")]
        public bool TestPlanGenerated { get; set; }

        [Display(Name = "Test Requester")]
        public string RequesterDisplayName { get; set; }

        public string ProjectCode { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }

        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
        public bool IsDeleted { get; set; }

        public string GetClassByTabName(string tabName)
        {
            if (TabState.Any(x => x.TabName == tabName))
            {
                return "fa fa-check";
            }
            return "fa fa-exclamation-circle";
        }

        public string GetClassByTabId(int tabId)
        {
            if (TabState.Any(x => x.TabId == tabId && x.Completed))
            {
                return "fa fa-check";
            }
            return "fa fa-exclamation-circle";
        }
    }
}