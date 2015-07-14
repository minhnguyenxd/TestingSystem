using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class TestRequestChannelViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int ChannelId { get; set; }
        public string ChannelName { get; set; }
        public int ChannelGroupId { get; set; }
        public string ChannelGroupName { get; set; }
        public int SaeClassId { get; set; }
        public string SaeClassName { get; set; }
        public bool Polarity { get; set; }
        public decimal Scale { get; set; }
        public int EngUnitId { get; set; }
        public string Unit { get; set; }
        public string SerialNumber { get; set; }
        public bool Verified { get; set; }
        public string VerifiedBy { get; set; }
        public string Source { get; set; }
        public int Sequenceno { get; set; }
        public string PolarityValue{
            get
            {
                return Polarity ? "Positive(+)" : "Negative(-)";
            }
        }

        public string VerifiedStatus
        {
            get
            {
                return Verified ? "Verified" : string.Empty;
            }
        }
    }
}
