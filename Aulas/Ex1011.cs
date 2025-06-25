// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double pi = 3.14159;
            
            double volumeSphere = (4.0/3) * pi * Math.Pow(radius,3);

            Console.WriteLine("VOLUME = " + volumeSphere.ToString("F3",CultureInfo.InvariantCulture));
        }

    }
}
