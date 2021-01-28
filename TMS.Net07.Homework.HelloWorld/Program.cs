using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true)
            {
                Console.WriteLine("Enter number: ");

                string input = Console.ReadLine();
                bool result = int.TryParse(input, out number);
                if (input == "0")
                {
                    return;
                }
                if (result == true)
                {
                    Console.WriteLine($"Your number is {number}");
                }
                else
                {
                    Console.WriteLine($"{input} is not number");
                }
            }
        }
    }
}
