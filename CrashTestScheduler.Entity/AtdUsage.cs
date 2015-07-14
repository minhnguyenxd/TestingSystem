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
    // AtdUsage
    public partial class AtdUsage : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int AtdId { get; set; } // AtdId
        public DateTime TrackDate { get; set; } // TrackDate
        public string Eng { get; set; } // Eng
        public string TrackBy { get; set; } // TrackBy
        public int? CalendarTypeId { get; set; } // CalendarTypeId
        public int? EvaluationTypeId { get; set; } // EvaluationTypeId
        public bool IsFailedChannel { get; set; } // IsFailedChannel
        public string GeneralComments { get; set; } // GeneralComments
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime CreatedDate { get; set; } // CreatedDate
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string UpdatedBy { get; set; } // UpdatedBy
        public bool? IsVerified { get; set; } // IsVerified
        public int? TestRequestId { get; set; } // TestRequestId
        public decimal? UsagePoint { get; set; } // UsagePoint
        public int? ComponentResultId { get; set; } // ComponentResultId
        public int? SledIterationId { get; set; } // SledIterationId

        // Foreign keys
        public virtual Atd Atd { get; set; } // FK_AtdUsage_Atd
        public virtual CalendarType CalendarType { get; set; } // FK_AtdUsage_CalendarType
        public virtual EvaluationType EvaluationType { get; set; } // FK_AtdUsage_EvaluationType
        public virtual TestRequest TestRequest { get; set; } // FK_AtdUsage_TestRequest

        public AtdUsage()
        {
            CreatedDate = System.DateTime.Now;
            IsVerified = false;
            UsagePoint = 0m;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
