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
    public class SledPostSummaryViewModel
    {
        public SledPostSummaryViewModel()
        {
            Operators = new List<UserViewModel>();
        }
        public int Id { get; set; }
        public int IterationId { get; set; }
        public bool? TestAnomaly { get; set; }
        public bool? TestMiss { get; set; }
        public bool? DataOnChim { get; set; }
        [StringLength(500, ErrorMessage = "Max length 500 characters")]    
        public string DataLocation { get; set; }
        public string TestEntryComments { get; set; }
        public string ResultComments { get; set; }
        public string SledOperator { get; set; }
        public string SledOperatorDisplayName { get; set; }
        public List<UserViewModel> Operators { get; set; }
        public bool IsCompleted { get; set; }
        public string Comments { get; set; }
    }
}