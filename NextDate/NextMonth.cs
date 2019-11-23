using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    public class NextMonth
    {
        public int year { private set; get; }

        public int month { private set; get; }

        public NextMonth(int year, int month)
        {
            this.year = year;
            this.month = month;
        }

        public void nextMonth()
        {
            month = month >= 12 ? month+1 : 1;
        }

        public NextMonth nextMonth(NextMonth month)
        {
            month.nextMonth();
            return month;
        }
    }
}
