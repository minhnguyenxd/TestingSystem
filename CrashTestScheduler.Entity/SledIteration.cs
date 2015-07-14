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
    // SledIteration
    public partial class SledIteration : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? TestRequestId { get; set; } // TestRequestId
        public bool? IsIteration { get; set; } // IsIteration
        public byte? RequestStatus { get; set; } // RequestStatus
        public DateTime? ScheduledTestDate { get; set; } // ScheduledTestDate
        public DateTime? ScheduledCompletedDate { get; set; } // ScheduledCompletedDate
        public int? SequenceNumber { get; set; } // SequenceNumber
        public string TestNumber { get; set; } // TestNumber
        public string IterationType { get; set; } // IterationType
        public int? TestPlanIterationId { get; set; } // TestPlanIterationId
        public bool? IsCompleted { get; set; } // IsCompleted

        // Reverse navigation
        public virtual ICollection<ChecklistTestPlan> ChecklistTestPlans { get; set; } // ChecklistTestPlan.FK_dbo_ChecklistTestPlan_SledIteration_IterationId
        public virtual ICollection<IrlTestPlan> IrlTestPlans { get; set; } // IrlTestPlan.SledIteration_IrlTesPlan_FK_IterationId
        public virtual ICollection<SledAtdInfo> SledAtdInfoes { get; set; } // SledAtdInfo.FK_dbo.SledAtdInfo_dbo.SledIteration_IterationId
        public virtual ICollection<SledPosition> SledPositions { get; set; } // SledPosition.FK_dbo.SledPosition_dbo.SledIteration_IterationId
        public virtual ICollection<SledPostSummary> SledPostSummaries { get; set; } // SledPostSummary.FK_SledPostSummary_SledPostSummary
        public virtual ICollection<SledPulseInfo> SledPulseInfoes { get; set; } // SledPulseInfo.FK_SledPulseInfo_SledIteration
        public virtual ICollection<SledResult> SledResults { get; set; } // SledResult.FK_dbo_SledResult_SledIteration_IterationId
        public virtual ICollection<SledSignal> SledSignals { get; set; } // SledSignal.FK_SledSignal_SledIteration
        public virtual ICollection<SledTestPlan> SledTestPlans { get; set; } // SledTestPlan.SledIteration_TesPlan_FK_IterationId
        public virtual ICollection<TestRequestPicture> TestRequestPictures { get; set; } // TestRequestPicture.FK_dbo_TestRequestPicture_SledIteration_IterationId
        public virtual ICollection<TestRequestVideo> TestRequestVideos { get; set; } // TestRequestVideo.FK_dbo_TestRequestVideo_SledIteration_IterationId

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.SledPulseInfo_dbo.SledTestRequest_TestRequestId

        public SledIteration()
        {
            ChecklistTestPlans = new List<ChecklistTestPlan>();
            IrlTestPlans = new List<IrlTestPlan>();
            SledAtdInfoes = new List<SledAtdInfo>();
            SledPositions = new List<SledPosition>();
            SledPostSummaries = new List<SledPostSummary>();
            SledPulseInfoes = new List<SledPulseInfo>();
            SledResults = new List<SledResult>();
            SledSignals = new List<SledSignal>();
            SledTestPlans = new List<SledTestPlan>();
            TestRequestPictures = new List<TestRequestPicture>();
            TestRequestVideos = new List<TestRequestVideo>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
