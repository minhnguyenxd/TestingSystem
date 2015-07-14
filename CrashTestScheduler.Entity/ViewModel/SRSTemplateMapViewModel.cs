using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CrashTestScheduler.Entity.ViewModel
{
    public class SRSTemplateMapViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int TemplateId { get; set; }
        public string SRSName { get; set; } 
        public int SrsId { get; set; } // SRSId
        public string LeftTtf { get; set; } // LeftTTF
        public bool LeftPickup { get; set; } // LeftPickup
        public bool LeftSquib { get; set; } // LeftSquib
        public string RightTtf { get; set; } // RightTTF
        public bool RightPickup { get; set; } // RightPickup
        public bool RightSquib { get; set; } // RightSquib
        public bool IsActive { get; set; } // IsActive
    }
}
