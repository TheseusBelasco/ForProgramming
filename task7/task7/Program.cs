using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = GetNumber("k");
            var m = GetNumber("m");
            var n = GetNumber("n");

            if (IsStatTrue(k, m, n))
                Console.WriteLine("Утверждение истинно");
            else
                Console.WriteLine("Утверждение ложно");

            Console.ReadKey();
        }

        static bool IsStatTrue(int k, int m, int n)
        {
            return (k%2==0 && m%2==0 && n%2==0) || (k % 2 != 0 && m % 2 != 0 && n % 2 != 0);
        }
        static int GetNumber(string numberName) 
        {
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());

        }
    }
}
