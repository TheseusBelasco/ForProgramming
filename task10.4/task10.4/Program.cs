using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Введите натуральное число n:");

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода. Введите натуральное число (больше 0).");
            }

            string binaryForm = Convert.ToString(n, 2);

            int ZerosCount = CountZeros(binaryForm);

            Console.WriteLine($"Количество значащих нулей: {ZerosCount}");

            Console.ReadKey();
        }

        static int CountZeros(string binary)
        {
            int count = 0;
            bool encounteredOne = false;

            foreach (char bit in binary)
            {
                if (bit == '1')
                {
                    encounteredOne = true;
                }
                else if (encounteredOne)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
