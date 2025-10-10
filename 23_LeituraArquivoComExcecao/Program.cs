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
            string caminho = @"C:\DesenvolvimentoSistema\SistemaAtendimento\arquivo.txt";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite um número para ler o arquivo ou -1 para sair:");

               
                if (!int.TryParse(Console.ReadLine(), out leitura))
                {
                    Console.WriteLine("Entrada inválida! Por favor, digite um número válido.");
                    Console.ReadKey();
                    
                }

                if (leitura == -1)
                {
                    Console.WriteLine("Encerrando o programa! Obrigado por utilizar.");
                    break;
                }

                try
                {
                    
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
                    Console.WriteLine($"Caminho atual do arquivo: {caminho}");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine("Ocorreu um erro inesperado.");
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
        }
    }
}
