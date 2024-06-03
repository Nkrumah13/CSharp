using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_do_Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

          double n = 3.14159;
            double raio;
            raio = double.Parse(Console.ReadLine());
            double area =  n * raio * raio;
            Console.WriteLine("A="+ area.ToString("0.0000"));
            Console.ReadKey();
                
        }
    }
}
