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
            


            double A, B, MEDIA;

            
            A = Convert.ToDouble(Console.ReadLine());

            
            B = Convert.ToDouble(Console.ReadLine());

            MEDIA = (A * 3.5 + B * 7.5) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("0.00000"));
            Console.ReadKey();
        }
    }
}
