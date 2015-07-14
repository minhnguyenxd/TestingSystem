using FileHelpers;

namespace CrashTestScheduler.Entity.Data
{
    [DelimitedRecord(",")]
    public class ChannelGroupFormat
    {
        public string SerialNumber;
        public string Name;
        public string IsoName;
        public string InvertPolarity;
        public string MaxRange;
        //Serial#,name,ISO,invert,max range
    }
}