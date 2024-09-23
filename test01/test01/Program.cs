using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Солнышко");

            Console.WriteLine();

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Вышло солнце в небеса\r\nИ глядит во все глаза.\r\nЗдравствуй, солнце золотое!\r\nХорошо гулять с тобою -\r\nСловно добрыми руками,\r\nОбнимаешь нас лучами.");

            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
