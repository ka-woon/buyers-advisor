using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersAdvisor
{
    public class WorkTime
    {
        public string StartDay { get; set; }
        public string EndDay { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public WorkTime() { }
        public WorkTime(string startDay, string endDay, string startTime, string endTime)
        {
            StartDay = startDay;
            EndDay = endDay;
            StartTime = startTime;
            EndTime = endTime;
        }
        public WorkTime(WorkTime workTime) : this(workTime.StartDay, workTime.EndDay, workTime.StartTime, workTime.EndTime) { }
        public override string ToString()
        {
            return $"{StartDay}-{EndDay} {StartTime}-{EndTime}";
        }
        public string PrintRawInfo()
        {
            return $"{StartDay}-{EndDay} {StartTime}-{EndTime}";
        }
    }
}
