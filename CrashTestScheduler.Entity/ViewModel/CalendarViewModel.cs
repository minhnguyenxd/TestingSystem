using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class CalendarViewModelResult
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<CalendarViewModel> Calendarlist {get;set;}

    }
    public class CalendarViewModel
    {
        public CalendarViewModel()
        {
            this.Url = string.Empty;
            this.backgroundColor = string.Empty;
            this.AllDay = false;
			this.textColor = "black";
        }

        public int Id { get; set; }
        public int BlockId { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool AllDay { get; set; }
        public string Url { get; set; }
        public bool JointCertification { get; set; } 

		private string _backgroundColor = string.Empty;
		public string backgroundColor
		{
			get
			{
				return _backgroundColor;
			}
			set
			{
				_backgroundColor = value;

                //if (_backgroundColor == ColorCode.Scheduled)
                //    this.textColor = "#646464";
			}
		}
		public string textColor { get; set; }
    }
}
