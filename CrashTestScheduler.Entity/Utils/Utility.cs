using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CrashTestScheduler.Entity.ViewModel;
using CrashTestScheduler.Entity.Model;
using CrashTestScheduler.Entity.ViewModel.Extensions;
using System.Collections;
namespace CrashTestScheduler.Entity.Utils
{
     

    public static class Utility
    {

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static DateRange GetMonthDateRangeByDate(DateTime dateoftheMonth)
        {
            var startDay = DateTime.Parse(dateoftheMonth.Month.ToString() + "/01/" + dateoftheMonth.Year.ToString());
            var endDay = startDay.AddMonths(1).AddDays(-1);
            return new DateRange { StartDate = startDay, EndDate = endDay };
        }

        public static DateRange GetWeekDateRangeByDate(DateTime dateoftheWeek)
        {
            var dayOffset = ((int) dateoftheWeek.DayOfWeek) * -1;
            var startDay = dateoftheWeek.AddDays(dayOffset);
            var endDay = startDay.AddDays(7);
            return new DateRange { StartDate = startDay, EndDate = endDay };
        }

        public static List<CalendarDay> AddTestRequestToCalendar(List<TestRequest> testRequests, DateTime startDay, CalendarViewType viewType, bool excludeWeekend = true)
        {
            var dateRange = viewType == CalendarViewType.Month ? GetMonthDateRangeByDate(startDay) : GetWeekDateRangeByDate(startDay);
            var cal = new List<CalendarDay>();

            for (var d = dateRange.StartDate; d <= dateRange.EndDate; d = d.AddDays(1) )
            {
                if( excludeWeekend && (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday))
                {
                    //override if there are test scheduled
                    var weekendtests = testRequests.Where(t => t.TestDate.ToString("yyyyMMdd") == d.ToString("yyyyMMdd")).ToList().ToViewModel();
                    if(weekendtests.Count > 0)
                    {
                        var weekendItem = new CalendarDay { ThisDayDate = d };
                        weekendItem.RequestItems = new List<CrashTestViewModel>();
                        weekendItem.RequestItems.AddRange(weekendtests);
                        cal.Add(weekendItem);
                    }
                    continue;
                }

                var item = new CalendarDay { ThisDayDate = d };
                var tests = testRequests.Where(t => t.TestDate.ToString("yyyyMMdd") == d.ToString("yyyyMMdd")).ToList().ToViewModel();
                if(tests.Count > 0)
                {
                    item.RequestItems = new List<CrashTestViewModel>();
                    item.RequestItems.AddRange(tests);
                }
                cal.Add(item);
            }

            return cal;
        }

        public static List<BridgeType> BridgeTypes
        {
            get
            {
                return new List<BridgeType> { new BridgeType { Name = "Half", Id = 1 }, new BridgeType { Name = "Full", Id = 1 } };
            }
        }

    }
}
