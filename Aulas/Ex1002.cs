// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double n = 3.14159;

            double circunferencia = n * Math.Pow(raio,2);

            Console.WriteLine("Circunferência: " + circunferencia.ToString("F4", CultureInfo.InvariantCulture));

        }

    }
}
