using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class TemplateInstrumentationChannelViewModel
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        [Display(Name = "Select Channel")]
        public int ChannelId { get; set; }
        [Display(Name = "Select Filter")]
        public int SaeClassId { get; set; }
        [Display(Name = "Positive Polarity")]
        public bool Polarity { get; set; }
        [Display(Name = "Full Scale")]
        public decimal Scale { get; set; }
        public int EngUnitId { get; set; }

        public string ChannelName { get; set; }
        public string SaeClassName { get; set; }
        public string Unit { get; set; }
        public int SequenceNo { get; set; }
        public string PolarityValue
        {
            get
            {
                return Polarity ? "Positive(+)" : "Negative(-)";
            }
        }
        
    }
}
