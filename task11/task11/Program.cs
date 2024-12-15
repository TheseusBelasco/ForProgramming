using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива:");

            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            var numbers = new double[n];
            var rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (rnd.NextDouble() * 20) - 10;
            }

            Console.WriteLine("Исходный массив:");

            PrintArray(numbers);

            Console.WriteLine();

            ModuleArray(numbers);

            Console.WriteLine();

            double result = Kvadr(numbers);
            Console.WriteLine($"Корень из суммы квадратов всех элементов: {result:F3}");

            Console.WriteLine();

            Console.WriteLine("Введите число k");
            int k;
            if (!int.TryParse(Console.ReadLine(), out k) || k < 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            GetSinus(numbers, k);

            Console.ReadKey();
        }

        static void PrintArray(double[] array)
        {
            foreach (var element in array)
                Console.Write($"{element:F3} ");

            Console.WriteLine();
        }

        static void ModuleArray(double[] array)
        {
            if (array == null || array.Length == 0)
                return;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    array[i] = Math.Abs(array[i]);
                }
            }

            Console.WriteLine("Измененный массив:");
            PrintArray(array);
        }

        static double Kvadr(double[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            double sumOfSquares = 0;

            foreach (var element in array)
            {
                sumOfSquares += element * element;
            }

            return Math.Sqrt(sumOfSquares);
        }

        static double[] GetSinus(double[] array, int k)
        {
            if (array == null || array.Length == 0)
                return new double[0];

            double[] result = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = Math.Sin(k * array[i]);
            }

            Console.WriteLine("Массив sin(kx):");
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }

            return result;
        }
    }
}
