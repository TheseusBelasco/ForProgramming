using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double E;

            // Ввод значения E
            Console.WriteLine("Введите значение E (E > 0):");
            while (!double.TryParse(Console.ReadLine(), out E) || E <= 0)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите положительное число.");
            }

            double a_n = 0;
            int n = 0;

            // Вычисление членов последовательности
            while (true)
            {
                a_n += Math.Pow(0.5, n); // a_n = 1 + 0.5 + 0.5^2 + ... + 0.5^n
                if (Math.Abs(2 - a_n) < E)
                {
                    break; // Условие выполнено, выходим из цикла
                }
                n++; // Увеличиваем индекс n
            }

            // Вывод результата
            Console.WriteLine($"Индекс n: {n}, Значение a_n: {a_n}");
            Console.ReadLine();
        }
    }
}
