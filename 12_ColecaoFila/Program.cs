using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<String> filaAtendimento = new Queue<String>();

            Console.WriteLine("=== Simulação de Fila de Atendimento ===");

            for (int i = 1; i <= 5; i++)
            {
                string nomeCliente = "Cliente " + i;
                do
                {


                    Console.WriteLine($"Digite o nome da 1ª pessoa: ");
                    nomeCliente = Console.ReadLine();

                    Console.WriteLine($"Digite o nome da 2ª pessoa: ");
                    nomeCliente = Console.ReadLine();


                    Console.WriteLine($"Digite o nome da 3ª pessoa: ");
                    nomeCliente = Console.ReadLine();



                }

            }
        }
    }
}
