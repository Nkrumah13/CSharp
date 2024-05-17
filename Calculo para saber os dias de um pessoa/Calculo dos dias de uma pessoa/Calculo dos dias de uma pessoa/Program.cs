using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_dos_dias_de_uma_pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita a data de nascimento do usuário
            Console.Write("Digite sua data de nascimento (no formato dd/mm/aaaa): ");
            string input = Console.ReadLine();

            // Converte a entrada para um objeto DateTime
            if (DateTime.TryParse(input, out DateTime dataNascimento))
            {
                // Calcula a diferença entre a data atual e a data de nascimento
                TimeSpan diferenca = DateTime.Now - dataNascimento;

                // Exibe o resultado em dias
                int diasDeVida = (int)diferenca.TotalDays;
                Console.WriteLine($"Você viveu aproximadamente {diasDeVida} dias.");
            }
            else
            {
                Console.WriteLine("Data de nascimento inválida. Certifique-se de usar o formato correto (dd/mm/aaaa).");
            }

            Console.ReadKey();
        }
    }
}




