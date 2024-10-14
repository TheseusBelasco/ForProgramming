using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "микросхема";
            Console.WriteLine($"Из слова \"{s}\" получили");

            var word1 = s
                .Remove(9)
                .Remove(6, 2)
                .Remove(3, 1)
                .Remove(0, 2);

            word1 += s
                .Substring(4, 2);

            Console.WriteLine(word1);

            var word2 = s
                .Remove(9)
                .Remove(6, 2)
                .Remove(0, 5)
                ;

            word2 += ReverseString(s
                .Remove(8, 2)
                .Remove(0, 6)
                );

            Console.WriteLine(word2);

            Console.ReadKey();
        }
        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}
