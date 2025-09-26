using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackNumeros = new Stack<int>();
            stackNumeros.Push(1);
            stackNumeros.Push(2);
            stackNumeros.Push(3);
            stackNumeros.Push(4);
            stackNumeros.Push(5);
            
            Console.WriteLine($"\n O Ùltimo número inserido foi: {stackNumeros.Peek()}");
            

        }
    }
}
