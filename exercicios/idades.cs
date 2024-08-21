/*using System;
using System.Globalization;

namespace ws_rider.exercicios
{
    public class idades
    {
        
        //Fazer um programa para ler o nome e idade de duas pessoas. Ao final mostrar uma mensagem com os
        //nomes e a idade média entre essas pessoas, com uma casa decimal, conforme exemplo.
        
        public static void Main(string[] args)
        {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade1, idade2;
            string nome1, nome2;
            double media;
            
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());


            media = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CI) + " anos.");

        }
    }
}*/