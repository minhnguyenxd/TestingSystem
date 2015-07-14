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
    // CalendarEvents
    public partial class CalendarEvent : EntityBase
    {
        public override  int Id { get; set; } // id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public string Title { get; set; } // title
        public DateTime Start { get; set; } // start
        public DateTime End { get; set; } // end
        public int TestStatus { get; set; } // TestStatus
        public string Url { get; set; } // url
        public string ProjectCode { get; set; } // ProjectCode
        public string TestModeName { get; set; } // TestModeName
        public string TestTypeName { get; set; } // TestTypeName
        public decimal ImpactSpeed { get; set; } // ImpactSpeed
        public string ImpactSide { get; set; } // ImpactSide
        public string PicName { get; set; } // PicName
        public string VehicleNumber { get; set; } // VehicleNumber
        public string LabName { get; set; } // LabName
        public string AtdConf { get; set; } // AtdConf
    }

}
