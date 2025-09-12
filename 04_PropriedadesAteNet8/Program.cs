using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conta conta = new Conta();
            Conta conta = new Conta("164-73");

            //conta.nome = "Paulo Vitor";
            conta.SetNome = "Paulo Vitor";

            //Não é possível atribuir o valor em um atributo privado

            // conta.numero = "164-73"; // Removido acesso direto ao campo privado

            // Use um método público para definir o número da conta

            //conta.Saldo = 1000.00m;
            conta.Depositar(-1000.00m);

            //Utilizando o método acessador Get para obter o saldo
            conta.setSaldo(1000.00m);
            // Console.WriteLine($"Saldo Atual: {conta.getSaldo():c2}");
            conta.ImprimirSaldo();

            while (true)
            {
                Console.WriteLine("Informe a Operação: [D]- Depositar, [S]- Sacar ou [E]- Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito); // Adicionado o método correto para depósito
                    conta.ImprimirSaldo();
                }

                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque); // Adicionado o método correto para saque
                    conta.ImprimirSaldo();
                }

                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"Conta: {conta.getSaldo()} Nome: {conta.SetNome} Saldo : {conta.getSaldo()}");
                    break;
                }

                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S] para Sacar ou [E] para Sair");
                }
            }
        }
    }

    public class Conta
    {
        private string numero;
        private string nome;

        // Transformar a conta Saldo com acesso privado
        private decimal saldo;

        // Novo método público para definir o número da conta

        public Conta (string Numero)
        {
            this.numero = Numero;
        }

        private string Setnome;

        public string SetNome { get; internal set; }

        public void SetNumero(string numero)
        {
            this.numero = numero;
        }

        //Métodos acessores (Get e Set)
        public decimal getSaldo()
        {
            return saldo;
        }

        public string getNumero()
        {
            return numero;
        }

        public string getNome()
        {
            return nome;
        }

        public void setSaldo(decimal saldo)
        {
            this.Depositar(saldo);
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;
            else
                Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= saldo)
                saldo -= valor;
            else
                Console.WriteLine("Saque inválido! Verifique o valor e o saldo disponível.");
        }

        public void ImprimirSaldo()
        {
            Console.WriteLine($"Saldo Atual: {saldo:c2}");
        }

       
    }
}
