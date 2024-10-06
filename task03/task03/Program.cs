using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество секунд \"n\", прошедших с начала суток: ");
            int n = int.Parse(Console.ReadLine());

            int chasi = n / 3600;
            int minuty = (n % 3600) / 60;
            int secundy = n % 60;

            Console.WriteLine(n + " с. это - " + chasi + " ч. " + minuty + " м. " + secundy + " с.");

            Console.ReadKey();
        }
    }
}
