using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение аргумента функции");
            var x = Double.Parse(Console.ReadLine());
            Console.WriteLine($"f({x}) = {MyFunction(x)}");

            Console.ReadKey();
        }

        static Double MyFunction(double x)
        {
            double result;

            if (x < -4) result=46;
            else if ((x >= -4) && (x <= 2)) result=(3 * x * x - 2);
            else result=10;

            return result;
        }
    }
}
