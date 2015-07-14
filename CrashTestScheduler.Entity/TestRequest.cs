// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrashTestScheduler.Entity.Model
{
    // TestRequest
    public partial class TestRequest : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public DateTime TestDate { get; set; } // TestDate
        public DateTime RequestedTestDate { get; set; } // RequestedTestDate
        public DateTime? ScheduledTestDate { get; set; } // ScheduledTestDate
        public DateTime? ChangeRequestDate { get; set; } // ChangeRequestDate
        public string TestNumber { get; set; } // TestNumber
        public string PicName { get; set; } // PicName
        public string PicPhone { get; set; } // PicPhone
        public string SensorPic { get; set; } // SensorPic
        public string SensorPicPhone { get; set; } // SensorPicPhone
        public string TestTechPic { get; set; } // TestTechPic
        public string TestTechPhone { get; set; } // TestTechPhone
        public byte RequestStatus { get; set; } // RequestStatus
        public string ScheduledBy { get; set; } // ScheduledBy
        public string ApprovedBy { get; set; } // ApprovedBy
        public DateTime? ApprovedDate { get; set; } // ApprovedDate
        public int? ProjectId { get; set; } // ProjectId
        public int? TestLaboratoryId { get; set; } // TestLaboratoryId
        public int? TestTypeId { get; set; } // TestTypeId
        public int? TestModeId { get; set; } // TestModeId
        public bool? HasTemplate { get; set; } // HasTemplate
        public bool JointCertification { get; set; } // JointCertification
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime CreatedDate { get; set; } // CreatedDate
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string UpdatedBy { get; set; } // UpdatedBy
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string VehicleNumber { get; set; } // VehicleNumber
        public string DeletedBy { get; set; } // DeletedBy
        public string ManualTestPlanPath { get; set; } // ManualTestPlanPath
        public string ManualPtcApprovalPath { get; set; } // ManualPtcApprovalPath
        public bool TestPlanGenerated { get; set; } // TestPlanGenerated
        public string PtcApprover { get; set; } // PtcApprover
        public string PtcApproverPhone { get; set; } // PtcApproverPhone
        public int? VehicleRecordId { get; set; } // VehicleRecordId
        public int? CalendarTypeId { get; set; } // CalendarTypeId
        public int? BuildLevelId { get; set; } // BuildLevelId
        public bool? IsScheduled { get; set; } // IsScheduled
        public int? PtcRequestStatus { get; set; } // PtcRequestStatus
        public DateTime? RequestCompletionDate { get; set; } // RequestCompletionDate
        public short? DailyTestNumber { get; set; } // DailyTestNumber

        // Reverse navigation
        public virtual ICollection<Approval> Approvals { get; set; } // Approval.FK_Approval_TestRequest
        public virtual ICollection<AtdUsage> AtdUsages { get; set; } // AtdUsage.FK_AtdUsage_TestRequest
        public virtual ICollection<Attachment> Attachments { get; set; } // Attachments.FK_dbo.Attachments_dbo.TestRequest_TestRequestId
        public virtual ICollection<BumperPendulumHit> BumperPendulumHits { get; set; } // BumperPendulumHit.FK_BumperPendulumHit_TestRequest
        public virtual ICollection<BumperPendulumResult> BumperPendulumResults { get; set; } // BumperPendulumResults.FK_BumperPendulumResults_TestRequest
        public virtual ICollection<ChecklistTestPlan> ChecklistTestPlans { get; set; } // ChecklistTestPlan.FK_dbo.ChecklistTestPlan_dbo.TestRequest_TestRequestId
        public virtual ICollection<ComponentsTestRequest> ComponentsTestRequests { get; set; } // ComponentsTestRequest.FK_dbo.ComponentsTestRequest_dbo.TestRequest_TestRequestId
        public virtual ICollection<ComponentsTestResult> ComponentsTestResults { get; set; } // ComponentsTestResult.FK_ComponentsTestResult_TestRequest
        public virtual ICollection<IrlTestRequest> IrlTestRequests { get; set; } // IrlTestRequest.FK_dbo.IrlTestRequest_dbo.TestRequest_TestRequestId
        public virtual ICollection<Notification> Notifications { get; set; } // Notifications.FK_Notifications_TestRequest
        public virtual ICollection<PtcSpec> PtcSpecs { get; set; } // PtcSpecs.FK_dbo.PtcSpecs_dbo.TestRequest_TestRequestId
        public virtual ICollection<RequestTabState> RequestTabStates { get; set; } // RequestTabState.FK_dbo.RequestTabState_dbo.TestRequest_TestRequestId
        public virtual ICollection<SledBlock> SledBlocks { get; set; } // SledBlock.FK_SledBlock_TestRequest
        public virtual ICollection<SledIteration> SledIterations { get; set; } // SledIteration.FK_dbo.SledPulseInfo_dbo.SledTestRequest_TestRequestId
        public virtual ICollection<SledTestRequest> SledTestRequests { get; set; } // SledTestRequest.FK_dbo.SledTestRequest_dbo.TestRequest_TestRequestId
        public virtual ICollection<SrsTestPlanMap> SrsTestPlanMaps { get; set; } // SRSTestPlanMap.FK_SRSTestPlanMap_TestRequest
        public virtual ICollection<TestPlan> TestPlans { get; set; } // TestPlan.FK_dbo.TestPlan_dbo.TestRequest_TestRequestId
        public virtual ICollection<TestPlanField> TestPlanFields { get; set; } // TestPlanFields.FK_dbo.TestPlanFields_dbo.TestRequest_TestRequestId
        public virtual ICollection<TestPlanSrsSetting> TestPlanSrsSettings { get; set; } // TestPlanSRSSetting.FK_dbo.TestPlanSRSSetting_dbo.TestRequest_TestRequestId
        public virtual ICollection<TestRequestChannel> TestRequestChannels { get; set; } // TestRequestChannel.FK_dbo.TestRequestChannel_dbo.TestRequest_TestRequestId
        public virtual ICollection<TestRequestComment> TestRequestComments { get; set; } // TestRequestComment.FK_dbo.TestRequestComment_dbo.TestRequest_TestRequestId
        public virtual ICollection<TestRequestCounterMeasure> TestRequestCounterMeasures { get; set; } // TestRequestCounterMeasure.FK_dbo.TestRequestCounterMeasure_dbo.TestRequest_TestRequestId
        public virtual ICollection<TestRequestDummy> TestRequestDummies { get; set; } // TestRequestDummy.FK_dbo.TestRequestDummy_dbo.TestRequest_TestRequestId
        public virtual ICollection<TestRequestEvent> TestRequestEvents { get; set; } // TestRequestEvent.FK_dbo.TestRequestEvent_dbo.TestRequest_TestRequestId
        public virtual ICollection<TestRequestPicture> TestRequestPictures { get; set; } // TestRequestPicture.FK_dbo.TestRequestPicture_dbo.TestRequest_TestRequestId
        public virtual ICollection<TestRequestVideo> TestRequestVideos { get; set; } // TestRequestVideo.FK_dbo.TestRequestVideo_dbo.TestRequest_TestRequestId

        // Foreign keys
        public virtual CalendarType CalendarType { get; set; } // FK_dbo.TestRequest_dbo.CalendarType_CalendarTypeId
        public virtual Project Project { get; set; } // FK_dbo.TestRequest_dbo.Project_ProjectId
        public virtual TestLaboratory TestLaboratory { get; set; } // FK_TestRequest_TestLaboratory_num
        public virtual TestMode TestMode { get; set; } // FK_dbo.TestRequest_dbo.TestMode_TestModeId
        public virtual TestType TestType { get; set; } // FK_dbo.TestRequest_dbo.TestType_TestTypeId

        public TestRequest()
        {
            Approvals = new List<Approval>();
            AtdUsages = new List<AtdUsage>();
            Attachments = new List<Attachment>();
            BumperPendulumHits = new List<BumperPendulumHit>();
            BumperPendulumResults = new List<BumperPendulumResult>();
            ChecklistTestPlans = new List<ChecklistTestPlan>();
            ComponentsTestRequests = new List<ComponentsTestRequest>();
            ComponentsTestResults = new List<ComponentsTestResult>();
            IrlTestRequests = new List<IrlTestRequest>();
            Notifications = new List<Notification>();
            PtcSpecs = new List<PtcSpec>();
            RequestTabStates = new List<RequestTabState>();
            SledBlocks = new List<SledBlock>();
            SledIterations = new List<SledIteration>();
            SledTestRequests = new List<SledTestRequest>();
            SrsTestPlanMaps = new List<SrsTestPlanMap>();
            TestPlans = new List<TestPlan>();
            TestPlanFields = new List<TestPlanField>();
            TestPlanSrsSettings = new List<TestPlanSrsSetting>();
            TestRequestChannels = new List<TestRequestChannel>();
            TestRequestComments = new List<TestRequestComment>();
            TestRequestCounterMeasures = new List<TestRequestCounterMeasure>();
            TestRequestDummies = new List<TestRequestDummy>();
            TestRequestEvents = new List<TestRequestEvent>();
            TestRequestPictures = new List<TestRequestPicture>();
            TestRequestVideos = new List<TestRequestVideo>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
