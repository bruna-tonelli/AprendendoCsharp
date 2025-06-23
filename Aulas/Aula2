// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());    //Utiliza o ponto ao invés da vírgula em doubles
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);      //"F2" = Casas após a vírgula, no caso após o ponto
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite as informações:");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            // Exercício
            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtddQuartpos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet2 = Console.ReadLine().Split(' ');
            string a = vet2[0];
            string b = vet2[1];
            string c = vet2[2];

            Console.WriteLine(name);
            Console.WriteLine(qtddQuartpos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);





        }

    }
}
