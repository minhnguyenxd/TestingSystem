using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int SequenceId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Comment { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
