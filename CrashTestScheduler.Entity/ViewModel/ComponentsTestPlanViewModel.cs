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
    public class ComponentsTestPlanViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public string FileAttachmentPath { get; set; }
        public string Type { get; set; }
    }
}