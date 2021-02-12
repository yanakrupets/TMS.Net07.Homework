using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.AdditionalTaskForHW3
{
    class FactorialRecursion
    {
        public static void Task()
        {
            Console.WriteLine("Enter number: ");
            long number;
            var inputNumber = Console.ReadLine();
            bool isNumber = long.TryParse(inputNumber, out number);
            if (isNumber)
            {
                if (number >= 0)
                {
                    Console.WriteLine(Factorial(number));
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

        static long Factorial(long number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
