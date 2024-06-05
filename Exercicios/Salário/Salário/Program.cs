using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double funcionario;
            double horas_de_trabalho;
            double valor_hora;
            
            funcionario = double.Parse(Console.ReadLine());
            horas_de_trabalho = double.Parse(Console.ReadLine());
            valor_hora = double.Parse(Console.ReadLine());
            double Salario = horas_de_trabalho * valor_hora;

            Console.WriteLine("NUMBER = " + funcionario);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
