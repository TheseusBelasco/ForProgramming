using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (!TryInputtingNumber("Введите количество действительных чисел:", out n))
            {
                Console.ReadKey();
                return;
            }

            if (n < 1)
            {
                Console.WriteLine("Количество не может быть меньше единицы.");
                Console.ReadKey();
                return;
            }

            double sum = 0;

            Console.WriteLine("Введите действительные числа через enter:");

            for (var i = 0; i < n; i++)
            {

                string input = Console.ReadLine();
                if (double.TryParse(input, out double a))
                {
                    sum += a;
                }
                else Console.WriteLine("Ошибка ввода. Введите действительное число.");
            }

            double average = sum / n;
            Console.WriteLine($"Среднее арифметическое: {average}");

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