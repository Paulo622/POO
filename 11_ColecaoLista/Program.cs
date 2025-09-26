using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                string nome;

                do
                {
                    Console.Write($"Digite o {i}° Nome (máx. 3 caracteres): ");
                    nome = Console.ReadLine();

                    if (nome.Length < 3)
                    {
                        Console.WriteLine("❌ O nome deve ter até 3 caracteres. Tente novamente!");
                    }

                } while (nome.Length > 3);

                nomes.Add(nome);
            }

            Console.WriteLine("Impressão dos Nomes:");
            foreach (string nome in nomes)
            {
                Console.WriteLine($" - {nome}");
            }
        }
    }
}
