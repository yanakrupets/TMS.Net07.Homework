using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.AdditionalTaskForHW3
{
    class Fibonachi
    {
        public static void Task()
        {
            Console.WriteLine("Enter number: ");
            int number;
            var inputNumber = Console.ReadLine();
            bool isNumber = int.TryParse(inputNumber, out number);
            if (isNumber)
            {
                if(number >= 0)
                {
                    Console.WriteLine(FibonachiFun(number));
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }

        static int FibonachiFun(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                return FibonachiFun(number - 1) + FibonachiFun(number - 2);
            }
        }
    }
}
