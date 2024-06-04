using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double A;
            //double B;

            //A = double.Parse(Console.ReadLine());   
            //B = double.Parse(Console.ReadLine());
            //if (A > 10.0)
            //{


            //    Console.WriteLine("Impóssivel");

            //}
            //double MEDIA = (A + B) / 2;
            //Console.WriteLine("MEDIA = " + MEDIA);


            //Console.ReadKey();


            double A, B, MEDIA;

            
            A = Convert.ToDouble(Console.ReadLine());

            
            B = Convert.ToDouble(Console.ReadLine());

            MEDIA = (A * 3.5 + B * 7.5) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("0.00000"));
            Console.ReadKey();
        }
    }
}
