using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            Dictionary<int,String> dicNomes = new Dictionary<int, string>();
            dicNomes.Add(1, "Paulo");
            dicNomes.Add(2, "Laura");
            dicNomes.Add(3, "Felipe");

            Console.WriteLine("Impressão dos dicNomes");
            for (int i = 1; i <= dicNomes.Count; i++)
            {
                Console.WriteLine($" - {dicNomes[i]}");
            }

            Dictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();
            dicAlunos.Add(paulo.id, paulo);
            dicAlunos.Add(laura.id, laura);

            Console.WriteLine("Impressão dos dicAlunos");
           // for (int i = 1; i <= dicAlunos.Count; i++)
          // {
           //    dicAlunos[i].ImprimirAluno();
           // }

            foreach (Aluno aluno in dicAlunos.Values)
            {
                aluno.ImprimirAluno();
            }

            Queue<String> filaNomes = new Queue<String>();
            filaNomes.Enqueue("Paulo");
            filaNomes.Enqueue("Laura");
            filaNomes.Enqueue("Felipe");

            Console.WriteLine("Impressão dos filaNomes");
            Console.WriteLine($" 1º) {filaNomes.Dequeue()}" );
            foreach (string nome in filaNomes)
            {
                
                Console.WriteLine($" - {nome}" );
            }

            Stack<String> stackNomes = new Stack<String>();
            stackNomes.Push("Paulo");
            stackNomes.Push("Laura");
            stackNomes.Push("Felipe");

            Console.WriteLine("Impressão dos stackNomes");
            Console.WriteLine($" 1º) {stackNomes.Pop()}");
            foreach (string nome in stackNomes)
            {
                Console.WriteLine($" - {nome}");
            }

            HashSet<String> setNomes = new HashSet<String>();
            setNomes.Add("Paulo");
            setNomes.Add("Laura");
            setNomes.Add("Felipe");
            setNomes.Add("Paulo");
            setNomes.Add("Laura");
            setNomes.Add("Felipe");

            Console.WriteLine("Impressão dos setNomes");
            foreach (string nome in setNomes)
            {
                Console.WriteLine($" - {nome}");
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
