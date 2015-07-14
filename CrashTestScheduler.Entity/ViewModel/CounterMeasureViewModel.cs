using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class CounterMeasureViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int SequenceId { get; set; }
        [Required]
        [MaxLength(255)]
        public string CounterMeasure { get; set; }
        public bool Completed { get; set; }

        public string VerifiedBy { get; set; }
        public string CompletedValue
        {
            get { return Completed ? "Completed" : string.Empty; }
        }
    }
}
