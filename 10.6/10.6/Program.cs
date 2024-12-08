using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Введите количество цифр, число n больше нуля: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("Некорректный ввод. Введите целое число больше нуля.");
            }

            int start = Power(10, n - 1);
            int end = Power(10, n) - 1;

            Console.WriteLine($"Простые {n}-значные числа:");
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }

        static int Power(int baseNum, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
