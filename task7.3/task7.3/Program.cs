using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого слона:");
            var whiteSlonPosit = Console.ReadLine();
            Console.WriteLine("Введите позицию чёрного слона:");
            var blackSlonPosit = Console.ReadLine();

            if (whiteSlonPosit == blackSlonPosit || IsWhiteSlonStrike(whiteSlonPosit, blackSlonPosit))
            {
                Console.WriteLine("Слоны не должны стоять под боем или на той же клетке.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите ход белого слона:");
            var move = Console.ReadLine();
            bool isValidMove = IsMoveCorrect(move, whiteSlonPosit, blackSlonPosit);
            Console.WriteLine(isValidMove ? "Ход возможен." : "Ход невозможен.");

            Console.ReadKey();
        }

        static bool IsWhiteSlonStrike(string whiteSlonPosit, string blackSlonPosit)
        {
            int wr, wc, br, bc;
            DecodePosition(whiteSlonPosit, out wc, out wr);
            DecodePosition(blackSlonPosit, out bc, out br);

            return (wr - wc) == (br - bc) || (wr + wc) == (br + bc);
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            row = int.Parse(position[1].ToString());
            column = position[0] - 'a' + 1;
        }

        static bool IsMoveCorrect(string move, string whiteSlonPosition, string blackSlonPosition)
        {
            int wc, wr, bc, br, mc, mr;
            DecodePosition(whiteSlonPosition, out wc, out wr);
            DecodePosition(blackSlonPosition, out bc, out br);
            DecodePosition(move, out mc, out mr);

            bool isInBounds = mc >= 1 && mc <= 8 && mr >= 1 && mr <= 8;
            bool isDiagonalMove = Math.Abs(wc - mc) == Math.Abs(wr - mr);
            bool isUnderAttack = IsWhiteSlonUnderAttack(move, blackSlonPosition);

            return isInBounds && isDiagonalMove && (move != blackSlonPosition) && !isUnderAttack;
        }

        static bool IsWhiteSlonUnderAttack(string position, string blackSlonPosition)
        {
            int pc, pr, bc, br;
            DecodePosition(position, out pc, out pr);
            DecodePosition(blackSlonPosition, out bc, out br);

            return (pr - pc) == (br - bc) || (pr + pc) == (br + bc);
        }

    }
}
