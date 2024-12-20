using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввыедите целое число m от 5 до 20");
            int m;

            if (!TryInputtingNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Ввыедите целое число n от 5 до 20");
            int n;

            if (!TryInputtingNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (m<5||m>20||n<5||n>20)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству 0 < m <=n");
                Console.ReadKey();
                return;
            }

            var matrix = new int[m, n];
            var rnd = new Random();

            for (int i = 0; i< matrix.GetLength(0); i++)
                for (int j = 0; j< matrix.GetLength(1); j++)
                    matrix[i,j] = rnd.Next(100);

            Console.WriteLine();
            PrintMatrix(matrix);
            Console.WriteLine();

            GetIndexOfNull(matrix);
            Console.WriteLine();
            CalculateDifferenceEvenOdd(matrix);

            Console.ReadKey();
        }

        static bool TryInputtingNumber(out int number)
        {

            number = 0;

            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            number = n;
            return true;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],2} ");
                

                Console.WriteLine();
            }
        }

        static void GetIndexOfNull(int[,] matrix)
        {
            bool foundZero = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Console.WriteLine($"Индекс строки и столбца, где есть ноль: {i+1}, {j+1}");
                        foundZero = true;
                        break;
                    }
                }
                if (foundZero) break;
            }

            if (!foundZero)
            {
                Console.WriteLine("Нет элемента, удовлетворяющего условию задачи");
            }
        }

        static void CalculateDifferenceEvenOdd(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sumEven = 0;
                int sumOdd = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sumEven += matrix[i, j];
                    }
                    else
                    {
                        sumOdd += matrix[i, j];
                    }
                }

                int difference = sumEven - sumOdd;
                Console.WriteLine($"{i + 1}, Разность сумм четных и нечетных элементов: {difference}");
            }
        }
    }
}
