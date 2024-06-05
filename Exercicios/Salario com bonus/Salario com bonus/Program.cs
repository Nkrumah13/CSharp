using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_com_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Vendedor = Console.ReadLine();
            double Salario;
            double vendas;
            Salario = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());
            double Total = vendas * 0.15 + Salario;
            Console.WriteLine(" TOTAL = R$ " + Total.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
