using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{


    public class NextDate
    {

        public int year { private set; get; }

        public int month { private set; get; }

        public int day { private set; get; }

        public NextDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;

        }

        public NextDate()
        {
            year = 1;
            month = 1;
            day = 1;
        }

        public bool isleap()
        {
            return isleap(this.year);
        }

        public static bool isleap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void nextday()
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (day == 31)
                    {
                        month = month + 1;
                        day = 1;

                    }
                    else
                    {
                        day = day + 1;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day == 30)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {
                        day += 1;
                    }
                    break;
                case 12:
                    if (day == 31)
                    {
                        month = 1;
                        day = 1;
                        year += 1;
                    }
                    else
                    {
                        day += 1;
                    }
                    break;
                case 2:
                    if (isleap())
                    {
                        if (day == 29)
                        {
                            day = 1;
                            month = 3;
                        }
                        else
                        {
                            day += 1;
                        }
                    }
                    else
                    {
                        if (day == 28)
                        {
                            day = 1;
                            month = 3;
                        }
                        else
                        {
                            day += 1;
                        }
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return year + "." + month + "." + day;
        }

        public NextDate nextday(NextDate next)
        {

            switch (next.month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (next.day == 31)
                    {
                        next.month += 1;
                        next.day = 1;

                    }
                    else
                    {
                        next.day += 1;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (next.day == 30)
                    {
                        next.month += 1;
                        next.day = 1;
                    }
                    else
                    {
                        next.day += 1;
                    }
                    break;
                case 12:
                    if (next.day == 31)
                    {
                        next.month = 1;
                        next.day = 1;
                        next.year += 1;
                    }
                    else
                    {
                        next.day += 1;
                    }
                    break;
                case 2:
                    if (isleap())
                    {
                        if (next.day == 29)
                        {
                            next.day = 1;
                            next.month = 3;
                        }
                        else
                        {
                            next.day += 1;
                        }
                    }
                    else
                    {
                        if (next.day == 28)
                        {
                            next.day = 1;
                            next.month = 3;
                        }
                        else
                        {
                            next.day += 1;
                        }
                    }
                    break;
            }

            return next;
        }

        public bool isDate(NextDate date)
        {
            bool flag = true;
            if ((date.year < 1) || (date.year > 2050) || (date.month < 1) || (date.month > 12))
            {
                flag = false;
            }
            else
            {
                switch (date.month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if ((date.day > 31) || (date.day < 1))
                            flag = false;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if ((date.day > 30) || (date.day < 1))
                            flag = false;
                        break;
                    case 2:
                        if (date.isleap())
                        {
                            if ((date.day > 29) || (date.day < 1))
                                flag = false;
                        }
                        else if ((date.day > 28) || (date.day < 1))
                            flag = false;
                        break;
                }
            }
            return flag;
        }

    }
}
