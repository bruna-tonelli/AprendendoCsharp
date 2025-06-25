// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[N,N];
            

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N ; j++)
                {
                    A[i,j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL = ");

            for (int i = 0; i < N; i++) {

                 Console.Write(A[i,i] + " ");
            }

            Console.WriteLine();

            int qtddNegativo = 0;

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        qtddNegativo++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + qtddNegativo);

        }

    }
}
