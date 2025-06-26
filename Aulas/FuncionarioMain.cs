// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo {
    class Program {
        static void Main(string[] args) {

            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionário: ");
            f1.nome = Console.ReadLine();
            f1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do segundo funcionário: ");
            f2.nome = Console.ReadLine();
            f2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine("Nome: " + f1.nome);
            Console.WriteLine("Salário: " + f1.salario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine("Nome: " + f2.nome);
            Console.WriteLine("Salário: " + f2.salario.ToString("F2", CultureInfo.InvariantCulture));

            double salarioMedio = (f1.salario + f2.salario) / 2.0;
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }


    }
}


