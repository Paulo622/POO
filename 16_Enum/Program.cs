using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sem a utilização de Enum");
            //List<int> diadaSemanaSemEnum = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            List<int> diadaSemanaSemEnum = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in diadaSemanaSemEnum)
            {
               /* if(item == 0) Console.WriteLine("Domingo");
                else if(item == 1) Console.WriteLine("Segunda");
                else if (item == 2) Console.WriteLine("Terça");
                else if (item == 3) Console.WriteLine("Quarta");
                else if (item == 4) Console.WriteLine("Quinta");
                else if (item == 5) Console.WriteLine("Sexta");
                else if (item == 6) Console.WriteLine("Sábado");
               */

                if (item == 1) Console.WriteLine("Domingo - Número 1");
                else if (item == 2) Console.WriteLine("Segunda - Número 2");
                else if (item == 3) Console.WriteLine("Terça -   Número 3");
                else if (item == 4) Console.WriteLine("Quarta -  Número 4");
                else if (item == 5) Console.WriteLine("Quinta -  Número 5");
                else if (item == 6) Console.WriteLine("Sexta -   Número 6");
                else if (item == 7) Console.WriteLine("Sábado -  Número 7");



            }

            Console.WriteLine("\n\nCom a utilização de Enum");
            List<DiadaSemana> diadaSemanaComEnum = new List<DiadaSemana>()
            {
                DiadaSemana.Domingo,
                DiadaSemana.Segunda,
                DiadaSemana.Terca,
                DiadaSemana.Quarta,
                DiadaSemana.Quinta,
                DiadaSemana.Sexta,
                DiadaSemana.Sabado
            };
            foreach (var item in diadaSemanaComEnum)
            {

                //{item} - Chama o método ToString implícito
                //{(int) item} - Converte o item do Enum para int
                Console.WriteLine($"{item.ToString()} Número: {(int) item}");
        }   }
    }

        public enum DiadaSemana
        {
            Domingo = 1,
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        }
}
