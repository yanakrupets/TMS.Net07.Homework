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
            Console.WriteLine("Enter numer: ");

            string input = Console.ReadLine();
            int number;
            bool result = int.TryParse(input, out number);
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
