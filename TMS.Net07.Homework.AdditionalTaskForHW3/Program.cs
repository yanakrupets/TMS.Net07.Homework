using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.AdditionalTaskForHW3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine($"Choose:{Environment.NewLine}1) Factorial cycle{Environment.NewLine}2) Factorial recursion{Environment.NewLine}" +
                    $"3) Fibonachi{Environment.NewLine}4) Exit");
                var choise = Console.ReadLine();
                switch(choise.ToLower())
                {
                    case ("1"):
                        FactorialCycle.Task();
                        break;
                    case ("2"):
                        FactorialRecursion.Task();
                        break;
                    case ("3"):
                        Fibonachi.Task();
                        break;
                    case ("4"):
                        return;
                    default:
                        Console.WriteLine("Wrong choise");
                        break;
                }
            }
        }
    }
}
