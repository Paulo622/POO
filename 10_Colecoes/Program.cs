using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<Genéric>
            List<string> nomes = new List<string>();
            nomes.Add("Paulo");
            nomes.Add("Laura");

            List<Aluno> alunos = new List<Aluno>();
            Aluno paulo = new Aluno { id = 1, Nome = "Paulo" };
            AlunoEspecial laura = new AlunoEspecial { id = 2, Nome = "Laura", Deficiencia = "Visual" };
            alunos.Add(paulo);
            alunos.Add(laura);

            alunos.Add(new Aluno { id = 3, Nome = "Felipe" }); // Erro de compilação
            nomes.Add(paulo.Nome); // Correto

            Console.WriteLine("Impressão dos nomes");
            foreach(string nome in nomes)
            {
                Console.WriteLine($" - {nome}");
            }

            Console.WriteLine("Impressão de alunos");
            foreach (Aluno aluno in alunos)
            {
               // Console.WriteLine($" - ID: {aluno.id} Nome: {aluno.Nome}");
               aluno.ImprimirAluno();
            }
           

        }
    }

    class Aluno
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public double[] Notas { get; set; }

        public virtual void ImprimirAluno()
        {
            Console.WriteLine($"ID: {this.id} Nome: {this.Nome}");
        }
    }

    class AlunoEspecial : Aluno
    {
        public string Deficiencia { get; set; }

        public override void ImprimirAluno()
        {
            Console.WriteLine($"ID: {this.id} Nome: {this.Nome} - {this.Deficiencia}");
        }
        
    }
}
