using System;

namespace Exercício_5_M
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int[,] b;
            int[,] c;

            string[] vetor = Console.ReadLine().Split(' ');
            int m = int.Parse(vetor[0]);
            int n = int.Parse(vetor[1]);

            a = new int[m, n];
            b = new int[m, n];
            c = new int[m, n];

            Console.WriteLine("Matriz 1 ");
            for (int l = 0; l < m; l++)
            {
                string[] vetor1 = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    a[l, i] = int.Parse(vetor1[i]);
                }
            }

            Console.WriteLine("Matriz 2 ");
            for (int l = 0; l < m; l++)
            {
                string[] vetor2 = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    b[l, i] = int.Parse(vetor2[i]);
                }
            }

            for (int l = 0; l < m; l++)
            {

                for (int i = 0; i < n; i++)
                {
                    c[l, i] = a[l, i] + b[l, i];
                }
            }

            Console.WriteLine("Matriz da soma : ");

            for (int l = 0; l < m; l++)
            {
                
                for (int i = 0; i < n; i++)
                {
                    Console.Write(c[l, i] + " ");
                }
                Console.WriteLine();
            }
         

        }
    }
}
