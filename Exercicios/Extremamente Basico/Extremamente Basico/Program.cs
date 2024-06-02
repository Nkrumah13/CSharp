using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extremamente_Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            int X = A + B;

            Console.WriteLine("X = " + X);
            Console.ReadKey();
        }
    }
}
