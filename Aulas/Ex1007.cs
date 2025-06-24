// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int difference = A * B - C * D;

            Console.WriteLine("DIFERENÇA = " + difference);
        }

    }
}
