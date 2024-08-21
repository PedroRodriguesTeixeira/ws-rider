using System;
using System.Runtime.InteropServices;

namespace ws_rider.exercicios
{
    
    public class diagonalNegativos
    {
        
        //Fazer um programa para ler um número inteiro N (máximo = 10) e uma matriz quadrada de ordem N
        //contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores
        //negativos da matriz.
        
        static void Main(string[] args)
        {
            int N, contadorNegativos = 0;
            
            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.Write("Diagonal principal: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i,i] + "  ");
            }

            Console.WriteLine();
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        contadorNegativos++;
                    }
                }
            }
            Console.WriteLine("Quantidade de negativos: " + contadorNegativos);
            
        }
    }
}