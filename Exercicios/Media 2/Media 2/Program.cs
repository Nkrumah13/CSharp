﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            MEDIA = (A * 2 + B * 3 + C * 5)/10;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("0.0"));
            Console.ReadKey();

        }
    }
}
