// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {

            string product1 = Console.ReadLine();
            string[] firstProduct = product1.Split(' ');
            string product2 = Console.ReadLine();
            string[] secondProduct = product2.Split(' ');

            int code1 = int.Parse(firstProduct[0]);
            int numberUnits1 = int.Parse(firstProduct[1]);
            double priceUnit1 = double.Parse(firstProduct[2], CultureInfo.InvariantCulture);

            int code2 = int.Parse(secondProduct[0]);
            int numberUnits2 = int.Parse(secondProduct[1]);
            double priceUnit2 = double.Parse(secondProduct[2], CultureInfo.InvariantCulture);

            double valueToPay = numberUnits1 * priceUnit1 + numberUnits2 * priceUnit2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valueToPay.ToString("F2", CultureInfo.InvariantCulture));


        }

    }
}
