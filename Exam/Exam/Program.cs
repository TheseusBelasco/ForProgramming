using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int m = 3; m <= 9; m++)
            {
                FindNuzhnChisla(m);
            }
            Console.ReadKey();
        }

        static void FindNuzhnChisla(int m)
        {
            int start = (int)Math.Pow(10, m - 1);
            int end = (int)Math.Pow(10, m) - 1;

            for (int n = start; n <= end; n++)
            {
                if (!AllChislaEqual(n))
                {
                    if (KaprekarFunction(n) == n)
                    {
                        Console.WriteLine(n);
                    }
                }
            }
        }

        static int KaprekarFunction(int n)
        {
            string vStroku = n.ToString();
            char[] chisla = vStroku.ToCharArray();

            Array.Sort(chisla);
            string poVozrastaniyu = new string(chisla);
            Array.Reverse(chisla);
            string poUbyvaniyu = new string(chisla);

            int numVozr = int.Parse(poVozrastaniyu);
            int numUbyv = int.Parse(poUbyvaniyu);

            return numUbyv - numVozr;
        }

        static bool AllChislaEqual(int n)
        {
            string vStroku = n.ToString();
            char firstChis = vStroku[0];

            foreach (char chis in vStroku)
            {
                if (chis != firstChis)
                {
                    return false;
                }
            }
            return true;
        }
    }
}