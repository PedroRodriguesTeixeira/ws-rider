/*using System;

namespace ws_rider
{
    public class matrizes
    {
        public static void Main(string[] args)
        {

            int M, N;
            Console.Write("Quantas linhas terá a matriz? ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas terá a matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[M,N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.WriteLine("Matriz digitada: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i,j] + " ");  
                }

                Console.WriteLine();
            }
        }
    }
}*/