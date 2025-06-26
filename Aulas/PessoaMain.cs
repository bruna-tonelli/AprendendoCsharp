// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo {
    class Program {
        static void Main(string[] args) {

            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Idade: " + p1.idade);
            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Idade: " + p2.idade);

            if (p1.idade > p2.idade) {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);

            }
            else {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }
        }


    }
}


