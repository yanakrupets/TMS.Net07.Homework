using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Calculator
{
    class Middle
    {
        public static void Task()
        {
            Console.WriteLine("Enter 2 numbers: ");
            var inputNumber1 = Console.ReadLine();
            var inputNumber2 = Console.ReadLine();
            double number1, number2;

            if (double.TryParse(inputNumber1, out number1) && double.TryParse(inputNumber2, out number2))
            {
                Console.WriteLine("Choose operation:\n+(addition)\n-(subtraction)\n*(multiplication)\n/(division)\n%(remainder of the division)");
                var choise = Console.ReadLine();
                switch (choise.ToLower())
                {
                    case ("+"):
                        Console.WriteLine($"Result is {number1 + number2}");
                        break;
                    case ("-"):
                        Console.WriteLine($"Result is {number1 - number2}");
                        break;
                    case ("*"):
                        Console.WriteLine($"Result is {number1 * number2}");
                        break;
                    case ("/"):
                        Console.WriteLine($"Result is {number1 / number2}");
                        break;
                    case ("%"):
                        Console.WriteLine($"Result is {number1 % number2}");
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
