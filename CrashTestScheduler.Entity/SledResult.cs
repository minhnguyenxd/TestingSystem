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
    // SledResult
    public partial class SledResult : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? SledScheduleTestId { get; set; } // SledScheduleTestId
        public string ResultType { get; set; } // ResultType
        public bool? ResultStatus { get; set; } // ResultStatus
        public bool? IsOffSiteLab { get; set; } // IsOffSiteLab
        public int? Speed { get; set; } // Speed
        public int? IstTestId { get; set; } // ISTTestID
        public int? IstProjectId { get; set; } // ISTProjectID
        public int? IstSingalId { get; set; } // ISTSingalID
        public string Comments { get; set; } // Comments
        public int? IterationId { get; set; } // IterationId
        public int? AdditionalSledWeight { get; set; } // AdditionalSledWeight
        public int? BreakPressure { get; set; } // BreakPressure
        public int? OilTemp { get; set; } // OilTemp
        public decimal? LabTemp { get; set; } // LabTemp
        public decimal? LabHumidity { get; set; } // LabHumidity
        public string AsisPulseName { get; set; } // ASISPulseName
        public string IstPreTrigger { get; set; } // ISTPreTrigger
        public string AsisTestName { get; set; } // ASISTestName
        public string AsisPreTrigger { get; set; } // ASISPreTrigger

        // Reverse navigation
        public virtual ICollection<SledPreTest> SledPreTests { get; set; } // SledPreTest.FK_dbo_SledPreTest_SledResult_ResultID

        // Foreign keys
        public virtual SledIstProject SledIstProject { get; set; } // FK_dbo_SledResult_SledISTProject_ISTProjectId
        public virtual SledIstSignalName SledIstSignalName { get; set; } // FK_dbo_SledResult_SledISTSignalProject_ISTSingalID
        public virtual SledIstTestName SledIstTestName { get; set; } // FK_dbo_SledResult_SledISTTestName_ISTTestID
        public virtual SledIteration SledIteration { get; set; } // FK_dbo_SledResult_SledIteration_IterationId
        public virtual SledScheduleTest SledScheduleTest { get; set; } // FK_dbo.SledResult_dbo.SledScheduleTest_SledScheduleTestId

        public SledResult()
        {
            SledPreTests = new List<SledPreTest>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
