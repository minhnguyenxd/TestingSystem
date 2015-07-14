using System;
using System.Linq;
using System.Text;
using CrashTestScheduler.Entity.ViewModel;

namespace CrashTestScheduler.Entity.Model
{
    // TestRequest
    public partial class TestRequest
    {


        public string GetCalendarTitle()
        {

            var testmodeName = TestMode == null ? string.Empty : TestMode.Name;

            return string.Format(" {0} {1} {2} {3} <br/>{4} <br/>{5} {6} {7} {8}",
                 GetFlags(), Project.FrameCode, TestType.Name.Replace("Crash Test", ""), testmodeName, GetTargetSide(), PicName, GetAtdForCalendar(), VehicleNumber, TestLaboratory.Name);

        }

        public string GetFlags()
        {
            return GetJointCertFlag() + GetPtcStatusFlag();
        }
        //
        public string GetJointCertFlag()
        {
            if (JointCertification)
            {
                return "<i class=\"fa fa-flag\" style=\"background-color: #79646; color:green\" ></i>";
            }
            return String.Empty;
        }
        public string GetPtcStatusFlag()
        {
            if (CalendarTypeId != 1)
            {
                return string.Empty;
            }
            var color = string.Empty;
            var title = string.Empty;


            switch (PtcRequestStatus.GetValueOrDefault())
            {
                case 0:
                    {
                        color = "red";
                        title = "PTC not submitted";

                        return string.Format("<i class=\"fa fa-circle\" style=\"color:{0}\" Title=\"{1}\" ></i>",
                               color, title);

                    }
                case 1:
                    {
                        color = "rgb(4, 15, 14)";
                        title = "PTC Requested";

                        return string.Format("<i class=\"fa fa-question-circle\" style=\"color:{0}\" Title=\"{1}\" ></i>",
                               color, title);
                    }
                case 2:
                    {
                        color = "green";
                        title = "PTC Approved";
                        return string.Format("<i class=\"fa fa-check-circle\" style=\"color:{0}\" Title=\"{1}\" ></i>",
                              color, title);
                        break;
                    }
            }
            return string.Empty;
        }
        public string GetSledCalendarTitle()
        {

            var testLab = TestLaboratory == null ? string.Empty : TestLaboratory.Name;
            var sledRequest = this.SledTestRequests.FirstOrDefault();
            var buckName = string.Empty;
            if (sledRequest != null)
            {
                buckName = sledRequest.SledBuck == null ? string.Empty : sledRequest.SledBuck.Name;
            }
            return string.Format("<i></i>{0} {1} {2} {3} {4} <br/> {5} {6}", GetFlags(),
                Project.FrameCode, TestType.Name, testLab, GetSledType(), buckName, PicName);

        }
        public string GetIrlCalendarTitle()
        {

            var testLab = TestLaboratory == null ? string.Empty : TestLaboratory.Name;
            return string.Format("{0} {1} {2} {3} {4}  {5}", GetFlags(),
                Project.FrameCode, TestType.Name, testLab, GetSledType(), PicName);

        }
        public string GetComponentCalendarTitle()
        {

            var testLab = TestLaboratory == null ? string.Empty : TestLaboratory.Name;
            return string.Format("<div  class=\"pull-left\">{0} {1}  <br/>{2} {3} <br/> {4}  {5} </div>  <div class=\"pull-right\"> {6} </div> ", GetFlags(),
                Project.FrameCode, TestType.Name, testLab, GetSledType(), PicName, GetTestStatus());

        }


        public string GetTestStatus()
        {
            if (RequestStatus == 3)
            {
                return "<span class=\"fa fa-flag\" style=\"width: 15px;display: inline-block\" ></span>";

            }
            return String.Empty;
        }

        public string GetSledType()
        {
            if (SledTestRequests.Count > 0)
            {
                var type = SledTestRequests.First().SledType;
                if (type != null)
                {
                    return type.Name;
                }
            }
            return string.Empty;

        }

        public string GetTargetSide()
        {
            if (TestPlans != null && TestPlans.FirstOrDefault() != null)
            {
                return TestPlans.FirstOrDefault().ImpactSide;

            }

            return string.Empty;
        }


        public string GetTargetTestSpeed()
        {
            if (TestPlans != null && TestPlans.FirstOrDefault() != null)
            {
                return TestPlans.FirstOrDefault().ImpactSpeed.ToString();

            }

            return string.Empty;
        }

        public string GetAtdForCalendar()
        {

            var atdsGrouped = TestRequestDummies.Where(t => t.Enabled == true).GroupBy(n => n.AtdType.Name).
                Select(group =>
                    new
                    {
                        Name = group.Key,
                        Count = group.Count()
                    }).ToList();

            var sb = new StringBuilder();
            foreach (var atd in atdsGrouped)
            {
                sb.Append(string.Format("{0}X{1} ", atd.Name, atd.Count));
            }
            return sb.ToString();
        }

        public string GetColorCode()
        {
            switch ((RequestStatus))
            {
                case 0:
                    return ColorCode.FirmRequest;
                case 1:
                    return ColorCode.Scheduled;
                case 2:
                    return ColorCode.PtcApproved;
                case 3:
                    return ColorCode.Completed;
                case 4:
                    return ColorCode.ChangeRequest;
                case 5:
                    return ColorCode.BudgetaryRequest;
                case 6:
                    return ColorCode.Cancelled;
                case 7:
                    return ColorCode.PtcRequested;
                case 8:
                    return ColorCode.BumperPendulumRequest;

            }

            return ColorCode.FirmRequest;
        }

        public DateTime GetTestDate()
        {
            return TestDate;

        }

        public string GetTextColor()
        {
            return "black";
        }


    }
}