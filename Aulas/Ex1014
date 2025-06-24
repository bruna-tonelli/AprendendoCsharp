// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalDistance = int.Parse(Console.ReadLine());
            double spentFuelTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumption = totalDistance / spentFuelTotal;

            Console.WriteLine(consumption.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }

    }
}
