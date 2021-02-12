using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Calculator
{
    class Easy
    {
        public static void Task()
        {
            Console.WriteLine("Input source currency: ");
            var sourceCurrency = Console.ReadLine();
            Console.WriteLine("Input target currency: ");
            var targetCurrency = Console.ReadLine();
            if ((sourceCurrency.ToLower() == "byn" || sourceCurrency.ToLower() == "eur" || sourceCurrency.ToLower() == "rub" || sourceCurrency.ToLower() == "usd")
                && (targetCurrency.ToLower() == "byn" || targetCurrency.ToLower() == "rub" || targetCurrency.ToLower() == "eur" || targetCurrency.ToLower() == "usd"))
            {
                Console.WriteLine("Input amount: ");
                var input = Console.ReadLine();
                if (decimal.TryParse(input, out var amount))
                {
                    CurrencyTranslation(sourceCurrency, targetCurrency, amount);
                }
                else
                {
                    Console.WriteLine("Wrong amount");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }

        static void CurrencyTranslation(string sourceCurrency, string targetCurrency, decimal amount)
        {

            if (sourceCurrency.ToLower() == "byn")
            {
                if (targetCurrency.ToLower() == "usd")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 0.38m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "eur")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 0.32m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "rub")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 28.80m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "byn")
                {
                    Console.WriteLine($"{amount} BYN is equal to {amount} BYN");
                    return;
                }
            }
            else if (sourceCurrency.ToLower() == "usd")
            {
                if (targetCurrency.ToLower() == "byn")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 2.63m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "rub")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 75.71m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "eur")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 0.83m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "usd")
                {
                    Console.WriteLine($"{amount} USD is equal to {amount} USD");
                    return;
                }
            }
            else if (sourceCurrency.ToLower() == "eur")
            {
                if (targetCurrency.ToLower() == "byn")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 3.16m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "rub")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 91.08m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "usd")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 1.20m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "eur")
                {
                    Console.WriteLine($"{amount} EUR is equal to {amount} EUR");
                    return;
                }
            }
            else if (sourceCurrency.ToLower() == "rub")
            {
                if (targetCurrency.ToLower() == "byn")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 0.035m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "usd")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 0.013m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "eur")
                {
                    Console.WriteLine($"{amount} {sourceCurrency} is equal to {amount * 0.011m} {targetCurrency}");
                }
                else if (targetCurrency.ToLower() == "rub")
                {
                    Console.WriteLine($"{amount} RUB is equal to {amount} RUB");
                    return;
                }
            }
        }
    }
}
