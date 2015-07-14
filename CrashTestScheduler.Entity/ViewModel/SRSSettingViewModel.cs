using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SRSSettingViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int TemplateId { get; set; }
        //left
        public string LeftFrontPrimaryAirBagTtf { get; set; }
        public bool LeftFrontPrimaryAirBagPickup { get; set; }
        public bool LeftFrontPrimaryAirBagSquib { get; set; }

        public string LeftFrontSecondaryAirBagTtf { get; set; }
        public bool LeftFrontSecondaryAirBagPickup { get; set; }
        public bool LeftFrontSecondaryAirBagSquib { get; set; }

        public string LeftOuterBeltTtf { get; set; }
        public bool LeftOuterBeltPickup { get; set; }
        public bool LeftOuterBeltSquib { get; set; }

        public string LeftSideAirBagTtf { get; set; }
        public bool LeftSideAirBagPickup { get; set; }
        public bool LeftSideAirBagSquib { get; set; }

        public string LeftSideCurtainAirBagTtf { get; set; }
        public bool LeftSideCurtainAirBagPickup { get; set; }
        public bool LeftSideCurtainAirBagSquib { get; set; }

        public string LeftInnerBuckleTtf { get; set; }
        public bool LeftInnerBucklePickup { get; set; }
        public bool LeftInnerBuckleSquib { get; set; }

        public string LeftOuterLapTtf { get; set; }
        public bool LeftOuterLapPickup { get; set; }
        public bool LeftOuterLapSquib { get; set; }

        public string LeftKneePrimaryTtf { get; set; }
        public bool LeftKneePrimaryPickup { get; set; }
        public bool LeftKneePrimarySquib { get; set; }

        //right
        public string RightFrontPrimaryAirBagTtf { get; set; }
        public bool RightFrontPrimaryAirBagPickup { get; set; }
        public bool RightFrontPrimaryAirBagSquib { get; set; }

        public string RightFrontSecondaryAirBagTtf { get; set; }
        public bool RightFrontSecondaryAirBagPickup { get; set; }
        public bool RightFrontSecondaryAirBagSquib { get; set; }

        public string RightOuterBeltTtf { get; set; }
        public bool RightOuterBeltPickup { get; set; }
        public bool RightOuterBeltSquib { get; set; }

        public string RightSideAirBagTtf { get; set; }
        public bool RightSideAirBagPickup { get; set; }
        public bool RightSideAirBagSquib { get; set; }

        public string RightSideCurtainAirBagTtf { get; set; }
        public bool RightSideCurtainAirBagPickup { get; set; }
        public bool RightSideCurtainAirBagSquib { get; set; }

        public string RightInnerBuckleTtf { get; set; }
        public bool RightInnerBucklePickup { get; set; }
        public bool RightInnerBuckleSquib { get; set; }

        public string RightOuterLapTtf { get; set; }
        public bool RightOuterLapPickup { get; set; }
        public bool RightOuterLapSquib { get; set; }

        public string RightKneePrimaryTtf { get; set; }
        public bool RightKneePrimaryPickup { get; set; }
        public bool RightKneePrimarySquib { get; set; }
    }
}
