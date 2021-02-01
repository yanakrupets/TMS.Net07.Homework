using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    class hard
    {
        public static void task()
        {
            while (true)
            {
                int day;
                int month;
                int year;
                Console.WriteLine("Введите вашу дату: ");
                var partsOfDate = Console.ReadLine().Split('.');
                if (partsOfDate.Length == 3)
                {
                    //string[] partsOfDate = input.Split('.');
                    bool isRightDay = int.TryParse(partsOfDate[0], out day);
                    bool isRightMonth = int.TryParse(partsOfDate[1], out month);
                    bool isRightYear = int.TryParse(partsOfDate[2], out year);
                    if(isRightDay==true &&isRightMonth==true&&isRightYear==true)
                    {
                        Date date = new Date(int.Parse(partsOfDate[0]), int.Parse(partsOfDate[1]), int.Parse(partsOfDate[2]));
                        date.Print();
                        date.DayOfWeek();
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод");
                    }
                }
                else if (partsOfDate[0].ToUpper() == "EXIT")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                }

            }
        }
    }
    enum DaysOfWeek
    {
        ПОНЕДЕЛЬНИК,
        ВТОРНИК,
        СРЕДА,
        ЧЕТВЕРГ,
        ПЯТНИЦА,
        СУББОТА,
        ВОСКРЕСЕНЬЕ
    }
    class Date
    {
        private int m_day;
        private int m_month;
        private int m_year;

        public Date()
        {
            m_day = 1;
            m_month = 1;
            m_year = 1;
        }

        public Date(int day, int month, int year)
        {
            if (Check(day, month, year) == false)
            {
                Console.WriteLine("Неверная дата");
            }
        }

        public void Print()
        {
            if (Check(m_day, m_month, m_year) == true)
            {
                Console.WriteLine($"Ваша дата: {m_day}.{m_month}.{m_year}");
            }
            else
            {
                Console.WriteLine("Нельзя вывести неверную дату");
            }
        }

        public void DayOfWeek()
        {
            if (Check(m_day, m_month, m_year) == true)
            {
                int count = 0;
                for (int i = 4; i < 2996; i += 4)
                {
                    count++;
                }
                int[] leapYears = new int[count];
                for (int i = 4, j = 0; i < 2996; i += 4, j++)
                {
                    if (i == 100 || i == 200 || i == 300 || i == 500 || i == 600 || i == 700 || i == 900 || i == 1000 || i == 1100 || i == 1300 || i == 1400
                        || i == 1500 || i == 1700 || i == 1800 || i == 1900 || i == 2100 || i == 2200 || i == 2300 || i == 2500 || i == 2600 || i == 2700 || i == 2900)
                    {
                        j--;
                    }
                    else
                    {
                        leapYears[j] = i;
                    }
                }

                int k = 0;
                int days = 0;
                if (m_year == 1)
                {
                    if (m_month == 1)
                    {
                        days = m_day;
                    }
                    else
                    {
                        for (int iMonth = 1; iMonth < m_month; iMonth++)
                        {
                            if (iMonth == 2 && m_year != leapYears[k])
                            {
                                days += 28;
                            }
                            else if (iMonth == 2 && m_year == leapYears[k])
                            {
                                days += 29;
                            }
                            else if (iMonth == 1 || iMonth == 3 || iMonth == 5 || iMonth == 7 || iMonth == 8 || iMonth == 10 || iMonth == 12)
                            {
                                days += 31;
                            }
                            else if (iMonth == 4 || iMonth == 6 || iMonth == 9 || iMonth == 11)
                            {
                                days += 30;
                            }
                        }
                        days += m_day;
                    }
                }
                else
                {
                    for (int iYear = 1; iYear < m_year; iYear++)
                    {
                        if (iYear != leapYears[k])
                        {
                            days += 365;
                        }
                        else
                        {
                            days += 366;
                            k++;
                        }
                    }
                    k = 0;
                    if (m_month == 1)
                    {
                        days += m_day;
                    }
                    else
                    {
                        for (int iMonth = 1; iMonth < m_month; iMonth++)
                        {
                            if (iMonth == 2 && m_year != leapYears[k])
                            {
                                days += 28;
                            }
                            else if (iMonth == 2 && m_year == leapYears[k])
                            {
                                days += 29;
                            }
                            else if (iMonth == 1 || iMonth == 3 || iMonth == 5 || iMonth == 7 || iMonth == 8 || iMonth == 10 || iMonth == 12)
                            {
                                days += 31;
                            }
                            else if (iMonth == 4 || iMonth == 6 || iMonth == 9 || iMonth == 11)
                            {
                                days += 30;
                            }
                        }
                        days += m_day;
                    }
                }

                int numberOfDayInWeek = 1;
                for (int i = 1; i < days; i++, numberOfDayInWeek++)
                {
                    if (numberOfDayInWeek == 8)
                    {
                        numberOfDayInWeek = 1;
                    }
                }
                if (numberOfDayInWeek == 8)
                {
                    numberOfDayInWeek = 1;
                }

                switch (numberOfDayInWeek)
                {
                    case (1):
                        Console.WriteLine(DaysOfWeek.ПОНЕДЕЛЬНИК);
                        break;
                    case (2):
                        Console.WriteLine(DaysOfWeek.ВТОРНИК);
                        break;
                    case (3):
                        Console.WriteLine(DaysOfWeek.СРЕДА);
                        break;
                    case (4):
                        Console.WriteLine(DaysOfWeek.ЧЕТВЕРГ);
                        break;
                    case (5):
                        Console.WriteLine(DaysOfWeek.ПЯТНИЦА);
                        break;
                    case (6):
                        Console.WriteLine(DaysOfWeek.СУББОТА);
                        break;
                    case (7):
                        Console.WriteLine(DaysOfWeek.ВОСКРЕСЕНЬЕ);
                        break;
                    default:
                        Console.WriteLine("Введите верно");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Нельзя определить день недели неверной даты");
            }
        }

        public bool Check(int checkDay, int checkMonth, int checkYear)
        {
            if (0 < checkDay && checkDay < 32 && 0 < checkMonth && checkMonth < 13 && 0 < checkYear && checkYear < 2999)
            {
                if (checkMonth == 2)
                {
                    int count = 0;
                    for (int i = 4; i < 2996; i += 4)
                    {
                        count++;
                    }
                    int[] leapYears = new int[count];
                    for (int i = 4, j = 0; i < 2996; i += 4, j++)
                    {
                        if (i == 100 || i == 200 || i == 300 || i == 500 || i == 600 || i == 700 || i == 900 || i == 1000 || i == 1100 || i == 1300 || i == 1400
                            || i == 1500 || i == 1700 || i == 1800 || i == 1900 || i == 2100 || i == 2200 || i == 2300 || i == 2500 || i == 2600 || i == 2700 || i == 2900)
                        {
                            j--;
                        }
                        else
                        {
                            leapYears[j] = i;
                        }
                    }
                    for (int i = 0; i < count; i++)
                    {
                        if (checkYear == leapYears[i])
                        {
                            if (checkDay <= 29)
                            {
                                m_day = checkDay;
                                m_month = checkMonth;
                                m_year = checkYear;
                                return true;
                            }
                            return false;
                        }
                    }
                    if (checkDay <= 28)
                    {
                        m_day = checkDay;
                        m_month = checkMonth;
                        m_year = checkYear;
                        return true;
                    }
                }
                else if (checkMonth == 1 || checkMonth == 3 || checkMonth == 5 || checkMonth == 7 || checkMonth == 8 || checkMonth == 10 || checkMonth == 12)
                {
                    if (checkDay <= 31)
                    {
                        m_day = checkDay;
                        m_month = checkMonth;
                        m_year = checkYear;
                        return true;
                    }
                    return false;
                }
                else if (checkMonth == 4 || checkMonth == 6 || checkMonth == 9 || checkMonth == 11)
                {
                    if (checkDay <= 30)
                    {
                        m_day = checkDay;
                        m_month = checkMonth;
                        m_year = checkYear;
                        return true;
                    }
                    return false;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
