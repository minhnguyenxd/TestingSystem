#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion


namespace CrashTestScheduler.Entity.ViewModel
{
    public class AttachmentViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public string FileAttachmentPath { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool? IsSubmitted { get; set; }
    }
}