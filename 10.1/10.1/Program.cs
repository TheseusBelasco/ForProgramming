using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            if (!TryInputtingNumber("Введите число n - количество фунтов:", out n) || n < 1)
            {
                Console.WriteLine("Пожалуйста, введите положительное целое число.");
                Console.ReadKey();
                return;
            }

            for (int pounds = 1; pounds <= n; pounds++)
            {
                double kilograms = pounds * 0.453;
                Console.WriteLine($"{pounds} ф. = {kilograms} кг.");
            }

            Console.ReadKey();
        }

        static bool TryInputtingNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            return true;
        }
    }
}