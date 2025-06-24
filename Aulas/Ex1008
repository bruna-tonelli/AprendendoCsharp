// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int workedHoursPerMonth = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double amountPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = workedHoursPerMonth * amountPerHour;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2",CultureInfo.InvariantCulture));
        }

    }
}
