using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = GetPositiveNumber("Введите годовую процентную ставку (x): ");
            double m = GetPositiveNumber("Введите сумму вклада (m): ");
            double k = GetPositiveNumber("Введите величину превышения (k): ");

            double monthlyRate = x / 100 / 12;

            double accumulatedAmount = m;
            int month = 0;
            double monthlyIncrease;

            do
            {
                month++;
                accumulatedAmount += accumulatedAmount * monthlyRate;
                monthlyIncrease = accumulatedAmount - m;
                m = accumulatedAmount;
            } while (monthlyIncrease <= k);

            Console.WriteLine($"Ежемесячное увеличение вклада превысит {k} рублей на {month} месяце.");

            Console.ReadKey();
        }

        static double GetPositiveNumber(string prompt)
        {
            double number;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out number) && number >= 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Введите положительное число.");
                }
            }
        }
    }
}