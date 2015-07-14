using CrashTestScheduler.Entity.ViewModel;
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
using Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrashTestScheduler.Entity.Model
{
    // CalendarEvents
    public partial class CalendarEvent : EntityBase
    {
        internal string GetTitle()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} <p>{6}</p> {7} {8} ",
                ProjectCode, TestTypeName, TestModeName, ImpactSpeed, ImpactSide, PicName, AtdConf, VehicleNumber,
                LabName).Replace("  ", " ");
        }

        public string GetColorCode()
        {
            switch (TestStatus)
            {
                case (int)RequestStatus.BumperPendulum:
                    return ColorCode.BumperPendulumRequest;
                case (int)RequestStatus.BudgetaryRequest:
                    return ColorCode.BudgetaryRequest;
                case (int)RequestStatus.TestCancelled:
                    return ColorCode.Cancelled;
                case (int)RequestStatus.ChangeRequested:
                    return ColorCode.ChangeRequest;
                case (int)RequestStatus.TestCompleted:
                    return ColorCode.Completed;
                case (int)RequestStatus.Requested:
                    return ColorCode.FirmRequest;
                case (int)RequestStatus.Scheduled:
                    return ColorCode.Scheduled;
                case (int)RequestStatus.PTCApproved:
                    return ColorCode.PtcApproved;
                case (int)RequestStatus.PTCRequested:
                    return ColorCode.PtcRequested;
            }

            return ColorCode.FirmRequest;
        }
    }

}
namespace CrashTestScheduler.Entity.Model
{
}
