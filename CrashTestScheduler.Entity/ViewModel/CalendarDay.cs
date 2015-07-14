using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{

    public enum CalendarViewType
    {
        Month,
        Week
    }

    public class CalendarDay
    {
        public DateTime ThisDayDate { get; set; }
        public List<CrashTestViewModel> RequestItems { get; set; }
        public string DayOfWeek
        {
            get
            {
                return ThisDayDate.DayOfWeek.ToString();
            }
        }
        public string ThisDay
        {
            get
            {
                return ThisDayDate.Day.ToString("D2");
            }
        }
        public string ThisMonth
        {
            get
            {
                return ThisDayDate.ToString("MMMM");
            }
        }
        public string ThisYear
        {
            get
            {
                return ThisDayDate.Year.ToString();
            }
        }

        public bool ThisDayIsToday
        {
            get
            {
                return DateTime.Compare(ThisDayDate, DateTime.Today) == 0;
            }
        }

    }

    public class DateRange
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
