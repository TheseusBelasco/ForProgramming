﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            PrintSinCos(15);

            PrintSinCos(37);

            PrintSinCos(113);

            double angleInDegrees;
            Console.WriteLine("Введите угол в градусах");
            angleInDegrees = double.Parse(Console.ReadLine());
            PrintSinCos(angleInDegrees);

            Console.ReadKey();

        }

        private static void PrintSinCos(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180;
            var sin = Math.Sin(angleInRadians);
            var cos = Math.Cos(angleInRadians);
            Console.WriteLine("sin(" + angleInDegrees + ") = " + Math.Round(sin, 3));
            Console.WriteLine("cos(" + angleInDegrees + ") = " + Math.Round(cos, 3));
        }
    }
}
