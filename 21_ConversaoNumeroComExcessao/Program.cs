using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ConversaoNumeroComExcessao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            while (true)
            {
                try
                {
                    Console.Write("Digite um número inteiro: ");
                    numero = int.Parse(Console.ReadLine());

                    int dobro = numero * 2;

                    Console.Clear();
                    Console.WriteLine("Você digitou o número: + numero");
                    Console.WriteLine("O dobro do número digitado é: " + dobro);
                    break;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
                }
                finally 
                {
                    Console.WriteLine("\nPressione qualquer tecla para sair...");
                    Console.ReadKey();
                }
            }
        }
    }
}
