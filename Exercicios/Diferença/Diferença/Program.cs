using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferença
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            int DIFERENCA = (A * B - C * D);
            Console.WriteLine("DIFERENCA = " + DIFERENCA);
            Console.ReadKey();

        }
    }
}
