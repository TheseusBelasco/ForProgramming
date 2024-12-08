using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double E;

            while (true)
            {
                Console.Write("Введите E (E > 0): ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out E) && E > 0)
                {
                    break;
                }
                Console.WriteLine("Некорректный ввод. Введите число больше нуля.");
            }

            double an = 1;
            int n = 0;

            while (Math.Abs(2 - an) >= E)
            {
                n++;
                an += Power(0.5, n);
            }

            Console.WriteLine($"Первый член последовательности an для которого |2 - an| < E: n = {n}, an = {an}");

            Console.ReadKey();
        }

        static double Power(double baseNum, int exponent)
        {
            double result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}