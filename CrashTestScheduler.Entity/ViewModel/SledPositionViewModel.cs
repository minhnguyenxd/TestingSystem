#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{

    public class SledPositionViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int IterationId { get; set; }
        public int? PositionOrder { get; set; }
        public int? TypeId { get; set; }
        public string SerialNumber { get; set; }
        public string TypeName { get; set; }
        public string PositionName { get; set; }
        public decimal? Pri { get; set; }
        public decimal? Sec { get; set; }
        public decimal? Elr { get; set; }
        public decimal? Oltp { get; set; }
        public decimal? Kab { get; set; }
        public decimal? Sab { get; set; }
        public decimal? Scap { get; set; }
        public decimal? Av { get; set; }
        public decimal? Buck { get; set; }
        public string Other { get; set; }
        public bool IsTestPlan { get; set; }
        public int CalendarTypeId { get; set; }
    }
   
}