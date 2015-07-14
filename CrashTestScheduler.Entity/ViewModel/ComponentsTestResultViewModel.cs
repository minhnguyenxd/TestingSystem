#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Humanizer;
using model = CrashTestScheduler.Entity.Model;
using CrashTestScheduler.Entity.Model;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ComponentsTestResultViewModel
    {
        public int Id { get; set; }
        public int TestTypeId { get; set; }
        public string TestType { get; set; }
        public int TestModeId { get; set; }
        public string TestMode { get; set; }
        public int TestRequestId { get; set; }
        public DateTime? ScheduledTestDate { get; set; }
        public DateTime? ScheduledCompletedDate { get; set; }
        public string TestNumber { get; set; }
        public int? SequenceNumber { get; set; }
        public byte? RequestStatus { get; set; }
        public string RequestStatusDisplayName { get; set; }
        public ComponentsPreTestViewModel ComponentsPreTest { get; set; }
        public ComponentsPostTestViewModel ComponentsPostTest { get; set; }
    }
}