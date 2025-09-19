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

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "123.456.789-00";
            pessoaFisica.Telefone = "(11) 99667-6049";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Empresa LTDA";
            pessoaJuridica.CNPJ = "01.455.678/0001-44";
            pessoaJuridica.Telefone = "(011) 3344-5566";
            pessoaJuridica.Imprimir();

            

        }
    }
}
