using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.ImprimirArea();

            Quadrado quadrado2 = new Quadrado(10);
            quadrado2.ImprimirArea();

            Retangulo retangulo = new Retangulo(15,5);
            retangulo.ImprimirArea();

            Circulo circulo = new Circulo(7.5);
            circulo.ImprimirArea();

            Triangulo triangulo = new Triangulo(9,2);
            triangulo.ImprimirArea();
        }


    }

    public class Quadrado
    {
        // Modificador de acesso Private
        // Pode ser acessado apenas dentro da própria classe
        private int lado;

        //Overload (Sobrecarga) de construtor
        //Declarar mais de um construtor com a lista de arguementos diferentes
        public Quadrado():this(5)
        {
           //this.lado = 5; 
        }

        //O construtor é um método especial que é chamado quando um objeto da classe é criado.
        // Inicializa o objeto com valores padrão ou fornecidos.
        public Quadrado(int lado)
        {
            //this. acessa o membro da classe
            if (lado > 0)
            this.lado = lado;
        }

        public int CalculaArea()
        {
            return lado * lado;
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"Quadrado com lado de {lado} possui uma área de {CalculaArea()}");
        }
    }

    public class Retangulo
    {
        private int largura;
        private int altura;
        // Construtor com dois parâmetros
        public Retangulo(int largura, int altura)
        {
            this.largura = largura;
            this.altura = altura;
        }
        public int CalculaArea()
        {
            return largura * altura;
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"Retângulo com largura de {largura} e altura de {altura} possui uma área de {CalculaArea()}");
        }
    }

    public class Circulo
    {
        private double raio;
        private const double PI = 3.14;
        // Construtor com um parâmetro
        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public double CalculaArea()
        {
            return PI * raio * raio;
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"Círculo com raio de {raio} possui uma área de {CalculaArea()}");
        }
    }

    public class Triangulo
    {
      private int baseTriangulo;
        private int altura;

        public Triangulo(int baseTriangulo, int altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public double CalculaArea()
        {
            return (baseTriangulo * altura) / 2.0;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Triângulo com base de {baseTriangulo} e altura de {altura} possui uma área de {CalculaArea()}");
        }
    }
}


