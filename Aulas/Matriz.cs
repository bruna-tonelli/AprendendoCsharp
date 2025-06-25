// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[,]A = new int[M,N]; 
          
            for (int  i = 0;i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i,j] + " ");

                }
                Console.WriteLine();

            }
         

        }

    }
}
