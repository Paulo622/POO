using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leitura = 0;
            string caminho = @"C:\Projetos\POO\arquivo.txt";

            while (true)
            {
                Console.WriteLine("Digite um número para ler o arquivo ou -1 para sair:");
                leitura = int.Parse(Console.ReadLine());
                Console.Clear();
                try
                {
                    if (leitura == -1)
                    {
                        Console.WriteLine("Encerrando o programa! Obrigado por utilizar.");
                        break;
                    }


                    string[] linhas = System.IO.File.ReadAllLines(caminho);
                    Console.WriteLine("Conteúdo do arquivo:");
                    foreach (string linha in linhas)
                    {
                        Console.WriteLine(linha);
                    }

                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine("Arquivo não encontrado. Por favor, verifique o caminho e tente novamente.");
                    Console.WriteLine(caminho);
                   
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
                    Console.WriteLine(caminho);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro: " + ex.Message);
                    Console.WriteLine(caminho);
            }   }
        }
    }
}
