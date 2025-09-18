using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Aluno aluno = new Aluno(nome);

            Console.WriteLine("Digite a Idade do aluno: ");
            aluno.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 1ª Nota do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 2ª Nota do aluno: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Média: " + aluno.Media());
            

            Console.WriteLine($"Nome: {aluno.Nome} Idade: {aluno.Idade} 1ªNota : {aluno.Nota1} 2ªNota : {aluno.Nota2} Media : {aluno.Media()} Situação : {aluno.Situacao()}");
            Console.ReadKey();

            return;
        }
       
    }
}
