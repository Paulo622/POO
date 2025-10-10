using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonlizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                try
                {
                    Console.Write("Digite a nota do aluno(0 a 10): ");
                    double nota = Convert.ToDouble(Console.ReadLine());
                   
                   

                    if (nota < 0 || nota > 10)
                    {
                        throw new NotaInvalidaException();
                    }
                    
                    if (nota >= 7)
                    {
                        Console.WriteLine("Aluno Aprovado!");
                       

                    }
                    else
                    {
                        Console.WriteLine("Aluno Reprovado!");
                        
                    }
                    Console.WriteLine("Pressione qualquer tecla para sair...");
                    Console.ReadKey();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("O valor da nota deve ser numérico!");
                    Console.ReadKey();
                }
                catch (NotaInvalidaException ex)
                {
                   Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.");
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }

            }
        }
    }
}
