using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите\n1) easy task\n2) middle task\n3) hard task\n4) exit");
                var choise = Console.ReadLine();
                switch (choise)
                {
                    case ("1"): easy.task();
                        break;
                    case ("2"): middle.task();
                        break;
                    case ("3"): hard.task();
                        break;
                    case ("4"):
                        return;
                    default: Console.WriteLine("Выберите верный вариант");
                        break;
                }
            }
        }
    }
}
