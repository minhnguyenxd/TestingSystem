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
    // SignalLocation
    public partial class SignalLocation : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string LocationName { get; set; } // LocationName
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy

        // Reverse navigation
        public virtual ICollection<SledPulseInfo> SledPulseInfoes { get; set; } // SledPulseInfo.FK_SledPulseInfo_SignalLocation
        public virtual ICollection<SledSignal> SledSignals { get; set; } // SledSignal.FK_dbo.SledSignal_dbo.SignalLocation_SignalLocationId

        public SignalLocation()
        {
            SledPulseInfoes = new List<SledPulseInfo>();
            SledSignals = new List<SledSignal>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
