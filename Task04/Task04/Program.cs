using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите необходимое значение x ");
            var x = double.Parse(Console.ReadLine());

            var y = MyFunc(x);

            Console.WriteLine($"Значение F(x) = {y}");

            Console.ReadKey();

        }

        static double MyFunc(double x)
        {
            //Вместо return something можно вставить заглушку -> throw new NotImplementedException();

            return ((Math.Sqrt(x + 1)) + (Math.Sqrt(x - 1))) / (Math.Sqrt(x));
        }

    }
}
