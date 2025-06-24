// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double totalValueSold = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double finalSalary = salary + 0.15 * totalValueSold;

            Console.WriteLine("TOTAL = R$ " + finalSalary.ToString("F2",CultureInfo.InvariantCulture));
        }

    }
}
