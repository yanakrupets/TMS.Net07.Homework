using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Choose task:{Environment.NewLine}1) Easy task{Environment.NewLine}2) Middle task{Environment.NewLine}3) Hard task{Environment.NewLine}4) Exit");
                var choise = Console.ReadLine();
                switch (choise.ToLower())
                {
                    case ("1"):
                        Easy.Task();
                        break;
                    case ("2"):
                        Middle.Task();
                        break;
                    case ("3"):
                        Hard.Task();
                        break;
                    case ("exit"):
                        return;
                    default:
                        Console.WriteLine("Wrong choise");
                        break;
                }
            }
        }
    }
}