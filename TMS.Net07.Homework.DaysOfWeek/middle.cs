using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    class Middle
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
            DateTime date;
            string inputDate;
            var maxDate = new DateTime(2999, 12, 31);
            while (true)
            {
                Console.WriteLine("Введите вашу дату: ");
                inputDate = Console.ReadLine();
                bool isDate = DateTime.TryParse(inputDate, out date);

                if (date > maxDate)
                {
                    Console.WriteLine("Введите другую дату");
                }
                else if (inputDate.ToUpper() == "EXIT")
                {
                    return;
                }
                else if (isDate == true)
                {
                    var day = Convert.ToString(date.DayOfWeek);
                    switch (day.ToUpper())
                    {
                        case ("MONDAY"):
                            Console.WriteLine(DaysOfWeek.ПОНЕДЕЛЬНИК);
                            break;
                        case ("TUESDAY"):
                            Console.WriteLine(DaysOfWeek.ВТОРНИК);
                            break;
                        case ("WEDNESDAY"):
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
                        default:
                            Console.WriteLine("Введите верно");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введите верно");
                }
            }
        }
    }
}
