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

            //Console.WriteLine("Digite dois números separados por espaço:");
            //string input = Console.ReadLine();
            //string[] inputs = input.Split(' ');

            //int num1 = int.Parse(inputs[0]);
            //int num2 = int.Parse(inputs[1]);

            //Console.WriteLine($"Os números digitados foram: {num1} e {num2}");

            //string input1 = Console.ReadLine();
            //string[] inputs = input1.Split(new char[] { });
            //int codpeca1 = int.Parse(inputs[0]);
            //int numpeca1 = int.Parse(inputs[1]);
            //float valorpeca1 = float.Parse(inputs[2]);   

            //string input2 = Console.ReadLine();
            //string[] inputs2 = input2.Split(new char[] { });
            //int numpeca2 = int.Parse(inputs[3]);
            //int codpeca2 = int.Parse(inputs[4]);    
            //float valorpeca2 = float.Parse(inputs[5]);

            //float resultado1 = (codpeca1 - numpeca1) / valorpeca1 + numpeca2 - codpeca2 * valorpeca2;
            //Console.WriteLine("VALOR A PAGAR: R$ "+resultado1);

            //Console.ReadKey();






            string input1 = Console.ReadLine(); string[] inputs = input1.Split(new char[] { ' ' });
            int codpeca1 = int.Parse(inputs[0]);
            int numpeca1 = int.Parse(inputs[1]);
            float valorpeca1 = float.Parse(inputs[2]);

            string input2 = Console.ReadLine(); string[] inputs2 = input2.Split(new char[] { ' ' });
            int codpeca2 = int.Parse(inputs2[0]);
            int numpeca2 = int.Parse(inputs2[1]);
            float valorpeca2 = float.Parse(inputs2[2]);

            float resultado1 = ((codpeca1 - numpeca1) * valorpeca1) + ((numpeca2 - codpeca2) * valorpeca2);
            Console.WriteLine("VALOR A PAGAR: R$ " + resultado1.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
