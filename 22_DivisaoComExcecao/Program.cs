using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1,numero2, resultado;
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Digite o primeiro número inteiro: ");
                    numero1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número inteiro: ");
                    numero2 = int.Parse(Console.ReadLine());

                    resultado = numero1 / numero2;


                    Console.WriteLine("\nO Resultado da Divisão é: ");
                    Console.WriteLine(resultado);
                    Console.ReadKey();
                    break;
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("Não é possivel dividir um numero por 0.");
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
                finally
                {
                    Console.WriteLine("Operação finalizada.Obrigado por utilizar o programa!");
                    Console.ReadKey();
                }
               
            }   
        }
    }
}
