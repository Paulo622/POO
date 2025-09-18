using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    internal class Aluno
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nome = value;
                }
                else
                {
                    Console.WriteLine("Nome inválido");
                }
            }
        }

        private int idade;
        public int Idade
        {
            get { return idade; }
            set
            {
                if (idade >= 0)
                {
                    idade = value;
                }
                else
                {
                    Console.WriteLine("Idade inválida");
                }
        }   }      
        
            private double nota1 { get; set; }
            private double nota2 { get; set; }

            public Aluno(string nome)
            {
                this.Nome = nome;
            }   

            public double Nota1
            {
                get { return nota1; }
                set { nota1 = value; }
            }

            public double Nota2

            {
                get { return nota2; }
                set { nota2 = value; }
            }

            public double Media()

            {
            
                return (nota1 + nota2) / 2;
            
            }

        public string Situacao()
        {
            return Media() >= 6 ? "Aprovado" : "Reprovado";
        }


    }
   
}
