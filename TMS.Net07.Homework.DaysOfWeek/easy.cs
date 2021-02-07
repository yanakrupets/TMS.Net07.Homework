using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    class Easy
    {
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
        public static void Task()
        {
            while (true)
            {
                Console.WriteLine("Введите день недели для перевода на русский: ");
                var day = Console.ReadLine();
                switch (day.ToUpper())
                {
                    case ("MONDAY"):
                        Console.WriteLine(DaysOfWeek.ПОНЕДЕЛЬНИК);
                        break;
                    case ("TUESDAY"):
                        Console.WriteLine(DaysOfWeek.ВТОРНИК);
                        break;
                    case ("WENSDAY"):
                        Console.WriteLine(DaysOfWeek.СРЕДА);
                        break;
                    case ("THURSDAY"):
                        Console.WriteLine(DaysOfWeek.ЧЕТВЕРГ);
                        break;
                    case ("FRIDAY"):
                        Console.WriteLine(DaysOfWeek.ПЯТНИЦА);
                        break;
                    case ("SATURDAY"):
                        Console.WriteLine(DaysOfWeek.СУББОТА);
                        break;
                    case ("SUNDAY"):
                        Console.WriteLine(DaysOfWeek.ВОСКРЕСЕНЬЕ);
                        break;
                    case ("EXIT"):
                        return;
                    default:
                        Console.WriteLine("Введите верно");
                        break;
                }
            }
        }
    }
}
