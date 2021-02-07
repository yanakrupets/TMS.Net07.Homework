using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TMS.Net07.Homework.Calculator
{
    class Hard
    {
        public static void Task()
        {
            Console.WriteLine("Enter expression: ");
            var expression = Console.ReadLine();
            string operation = string.Empty;
            expression = expression.Replace(" ", string.Empty);
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/' || expression[i] == '%')
                {
                    operation = Convert.ToString(expression[i]);
                    break;
                }
                else if (expression[0] == 's' && expression[1] == 'q' && expression[2] == 'r' && expression[3] == 't')
                {
                    operation = "sqrt";
                    break;
                }
                else if (expression[0] == 's' && expression[1] == 'q' && expression[2] == 'r')
                {
                    operation = "sqr";
                    break;
                }
                else if(expression[i] == 'p' && expression[i+1] == 'o' && expression[i+2] == 'w')
                {
                    operation = "p";
                    expression = expression.Replace("o", string.Empty);
                    expression = expression.Replace("w", string.Empty);
                    break;
                }
            }

            if (operation == string.Empty)
            {
                Console.WriteLine("No operation");
            }

            else if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%" || operation == "p")
            {
                string[] partsOfExpression = expression.Split(Convert.ToChar(operation));
                if (partsOfExpression.Length == 2)
                {
                    double number1;
                    double number2;
                    bool isNumber1 = double.TryParse(partsOfExpression[0], out number1);
                    bool isNumber2 = double.TryParse(partsOfExpression[1], out number2);
                    if (isNumber1 && isNumber2 && operation == "+")
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {number1 + number2}");
                    }
                    else if (isNumber1 && isNumber2 && operation == "-")
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {number1 - number2}");
                    }
                    else if (isNumber1 && isNumber2 && operation == "*")
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {number1 * number2}");
                    }
                    else if (isNumber1 && isNumber2 && operation == "/")
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {number1 / number2}");
                    }
                    else if (isNumber1 && isNumber2 && operation == "%")
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {number1 % number2}");
                    }
                    else if(isNumber1 && isNumber2 && operation == "p")
                    {
                         Console.WriteLine($"{number1} pow {number2} = {Math.Pow(number1, number2)}");
                    }
                    else
                    {
                        Console.WriteLine("Wrong expression");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong expression");
                }
            }

            else if(operation == "sqr")
            {
                string[] partsOfExpression = expression.Split(Convert.ToChar('r'));
                if (partsOfExpression.Length == 2)
                {
                    int number;
                    bool isNumber = int.TryParse(partsOfExpression[1], out number);
                    if(isNumber)
                    {
                        Console.WriteLine($"sqr {number} = {number * number}");
                    }
                    else
                    {
                        Console.WriteLine("Wrong expression");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong expression");
                }
            }
            
            else if(operation == "sqrt")
            {
                string[] partsOfExpression = expression.Split(Convert.ToChar('t'));
                if (partsOfExpression.Length == 2)
                {
                    int number;
                    bool isNumber = int.TryParse(partsOfExpression[1], out number);
                    if (isNumber)
                    {
                        Console.WriteLine($"sqrt {number} = {Math.Sqrt(number)}");
                    }
                    else
                    {
                        Console.WriteLine("Wrong expression");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong expression");
                }
            }
        }
    }
}
