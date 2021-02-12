using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.AdditionalTaskForHW3
{
    class FactorialCycle
    {
        public static void Task()
        {
            Console.WriteLine("Enter number: ");
            int number;
            var inputNumber = Console.ReadLine();
            bool isNumber = int.TryParse(inputNumber, out number);
            var factorial = 1;
            if (isNumber)
            {
                if (number < 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    for (var i = 1; i <= number; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine(factorial);
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
