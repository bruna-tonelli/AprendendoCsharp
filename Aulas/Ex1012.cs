// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double areaTriangle = (A * C) / 2;
            double areaCircle = Math.Pow(C, 2) * 3.14159;
            double areaTrapezium = ((A + B) * C) / 2;
            double areaSquare = Math.Pow(B, 2);
            double areaRectangle = A * B;

            Console.WriteLine("TRIANGULO: " + areaTriangle.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCircle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezium.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaSquare.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRectangle.ToString("F3", CultureInfo.InvariantCulture));

                
        }

    }
}
