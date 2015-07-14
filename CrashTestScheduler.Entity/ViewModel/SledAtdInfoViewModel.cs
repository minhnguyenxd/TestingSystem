#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SledAtdInfoViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int IterationId { get; set; }
        public string SeatingPosition { get; set; }
        public int PositionOrder { get; set; }
        public int AtdTypeId { get; set; }
        public string AtdTypeName { get; set; }
        public bool InstrumentationLegs { get; set; }
    }
}