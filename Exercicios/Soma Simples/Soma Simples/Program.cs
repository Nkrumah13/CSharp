using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            int SOMA = A + B;
            Console.WriteLine("SOMA = " + SOMA);
            Console.ReadKey();

        }
    }
}
