#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Humanizer;
using model = CrashTestScheduler.Entity.Model;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
}

namespace CrashTestScheduler.Entity.ViewModel
{
    
    public class IrlTestPlanViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int IterationId { get; set; }
        public int TestId { get; set; }
        public string TestType { get; set; }
        public string TestMode { get; set; }
        public string Row { get; set; }
        public string Position { get; set; }
        public string Temperature { get; set; }
        public string TestNumber { get; set; }
        public int PosType { get; set; }
        public int? PosAtdTypeId { get; set; }
        public bool? IsPosTtfFilled { get; set; } // IsPosTtfFilled
        public int? SerialNo { get; set; }
        public int? CurrentSerialNo { get; set; }
        public string PosTypeName { get; set; }
        public string PosAtdTypeName { get; set; }
    }
}