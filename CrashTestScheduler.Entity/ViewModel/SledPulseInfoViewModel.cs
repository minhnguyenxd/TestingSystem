#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SledPulseInfoViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int IterationId { get; set; }
        //public int PositionOrder { get; set; }
        //public string TestType { get; set; }
        //public string SledType { get; set; }
        //public string InfoTestType { get; set;}
        //public string ProjectCode { get; set; }
        public int LocationId { get; set;       }
        public string LocationName { get; set; }
        public string Name { get; set; }
        public string Pulse { get; set; }
    }
}