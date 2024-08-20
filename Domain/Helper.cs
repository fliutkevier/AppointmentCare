using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Helper
    {
        public static bool IsOnlyNumber(string txt)
        {
            int isNumber;
            if (int.TryParse(txt, out isNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<TimeOnly> listSchedules()
        {
            List<TimeOnly> schedules = new List<TimeOnly>();
            TimeOnly time = new TimeOnly(07, 0);
            
            int cantHours = 12;

            for (int i = 0; i < cantHours; i++)
            {
                var hours = time.AddHours(i);
                schedules.Add(hours);
            }
            return schedules;
        }
    }
}
