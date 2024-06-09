using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int codigopeca1, codigopeca2, numeropeca1, numeropeca2;
            // float valorpeca1, valorpeca2;

            // Lendo os dados da peça 1
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(peca1[0]);
            int numeroPecas1 = int.Parse(peca1[1]);
            double valorUnitarioPeca1 = double.Parse(peca1[2]);

            // Lendo os dados da peça 2
            string[] peca2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(peca2[0]);
            int numeroPecas2 = int.Parse(peca2[1]);
            double valorUnitarioPeca2 = double.Parse(peca2[2]);

            // Calculando o valor total a ser pago
            double totalPagar = (numeroPecas1 * valorUnitarioPeca1) + (numeroPecas2 * valorUnitarioPeca2);

            // Exibindo o resultado
            Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("F2"));
            Console.ReadKey();


        }
    }
}
