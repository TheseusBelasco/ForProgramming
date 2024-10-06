using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону правильного треугольника");
            var storona = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту пирамиды");
            var visota = double.Parse(Console.ReadLine());

            var ploschTreug = (Math.Pow(storona, 2) * Math.Sqrt(3)) / 4;
            Console.WriteLine("Площадь равностороннего треугольника = " + Math.Round(ploschTreug, 2) + " квадратных единиц");

            Console.WriteLine();

            var obyom = (ploschTreug *  visota)/3;
            Console.WriteLine("Объём пирамиды с равносторонним треугольным основанием = " + Math.Round(obyom, 2) + " кубических единиц");

            Console.WriteLine();

            double visotaBokovaya = Math.Sqrt(Math.Pow(visota, 2) + Math.Pow(storona / 2, 2));
            double PloschBokovaya = (1.0 / 2) * storona * visotaBokovaya;
            double ploschStoron = 3 * PloschBokovaya;
            Console.WriteLine("Площадь всех сторон треугольника = " + Math.Round(ploschStoron,2) + " квадратных единиц");

            Console.WriteLine();

            var obschPosch = ploschTreug + ploschStoron;
            Console.WriteLine("Площадь поверхности пирамиды = " + Math.Round(obschPosch,2) + " квадратных единиц");

            Console.ReadKey();
        }
    }
}
