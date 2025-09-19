using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Não é possível instanciar uma classe abstrata
            //Pessoa obj = new Pessoa();

            Pessoa[] pessoas = new Pessoa[2];

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoas[0] = pessoaFisica;
            pessoaFisica.Id = 1;
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "123.456.789-00";
            pessoaFisica.Telefone = "(11) 99667-6049";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoas[1] = pessoaJuridica;
            pessoaJuridica.Id = 1;
            pessoaJuridica.Nome = "Empresa LTDA";
            pessoaJuridica.CNPJ = "01.455.678/0001-44";
            pessoaJuridica.Telefone = "(011) 3344-5566";
            pessoaJuridica.Imprimir();

            Console.WriteLine(pessoaJuridica);
            Console.WriteLine(pessoaFisica);

            if (pessoaFisica.Equals(pessoaJuridica))
                Console.WriteLine($"É a mesma pessoa");
            else
                Console.WriteLine($"Não é a mesma pessoa");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
