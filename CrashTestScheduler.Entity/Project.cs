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
    // Project
    public partial class Project : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string ProjectCode { get; set; } // ProjectCode
        public string Comments { get; set; } // Comments
        public string FrameCode { get; set; } // FrameCode
        public int SeatRows { get; set; } // SeatRows
        public string ProjectLead { get; set; } // ProjectLead
        public string ProjectLeadEmail { get; set; } // ProjectLeadEmail
        public bool IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy
        public DateTime CreatedDate { get; set; } // CreatedDate
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string UpdatedBy { get; set; } // UpdatedBy

        // Reverse navigation
        public virtual ICollection<ProjectBuildLevel> ProjectBuildLevels { get; set; } // ProjectBuildLevel.FK_ProjectBuildLevel_Project
        public virtual ICollection<SledScheduleTest> SledScheduleTests { get; set; } // SledScheduleTest.FK_dbo.SledScheduleTest_dbo.SledTestRequest_TestRequestId
        public virtual ICollection<TestRequest> TestRequests { get; set; } // TestRequest.FK_dbo.TestRequest_dbo.Project_ProjectId

        public Project()
        {
            ProjectBuildLevels = new List<ProjectBuildLevel>();
            SledScheduleTests = new List<SledScheduleTest>();
            TestRequests = new List<TestRequest>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
