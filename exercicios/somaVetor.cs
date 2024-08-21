/*using System;
using System.Globalization;

namespace ws_rider.exercicios
{
    public class somaVetor
    
    //Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida:
    //- Imprimir todos os elementos do vetor
    //- Mostrar na tela a soma e a média dos elementos do vetor
    
    {
        public static void Main(string[] args)
        {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            int N;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vetor = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vetor[i] = double.Parse(Console.ReadLine(), CI);
            }
            Console.WriteLine();

            Console.Write("Valores = ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(vetor[i].ToString("F1", CI) + " ");
            }
            Console.WriteLine();
            
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma += vetor[i];
            }
            Console.WriteLine("Soma = " + soma.ToString("F2",  CI));

            double media = soma / N;
            Console.WriteLine("Media = " + media.ToString("F2", CI));
        }
    }
}*/