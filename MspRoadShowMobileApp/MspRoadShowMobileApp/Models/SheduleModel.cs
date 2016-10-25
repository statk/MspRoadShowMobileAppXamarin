using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MspRoadShowMobileApp.Models
{
    public class SheduleModel
    {
        public string name { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public List<string> speakers { get; set; }
        public string StartTime
        {
            get
            {
                var min = startTime.Minute.ToString().Length <= 1 ? $"{startTime.Minute}0" : startTime.Minute.ToString();
                var hour = startTime.Hour.ToString().Length <= 1 ? $"0{startTime.Hour}" : startTime.Hour.ToString();
                return $"{hour}:{min}";
            }
        }

        public string EndTime
        {
            get
            {
                var min = endTime.Minute.ToString().Length <= 1 ? $"{endTime.Minute}0" : endTime.Minute.ToString();
                var hour = endTime.Hour.ToString().Length <= 1 ? $"0{endTime.Hour}" : endTime.Hour.ToString();
                return $"{hour}:{min}";
            }
        }
    }
}
