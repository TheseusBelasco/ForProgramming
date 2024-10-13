using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var x = F(2, 3) + F(3, 7) + F(5, 5);
            Console.WriteLine($"x = {x:F3}");

            Console.ReadKey();

        }

        static double F(double a, double b)
        {

            return Math.Sqrt(a + Math.Log(1 + Math.Sqrt(b)));

        }
    }
}