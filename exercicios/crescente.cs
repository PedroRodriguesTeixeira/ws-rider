/*using System;

namespace ws_rider.exercicios
{
    public class crescente
    {
        
        //Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma
        //mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente. O
        //programa deve finalizar quando forem digitados dois valores iguais.
        
        public static void Main(string[] args)
        {
            int x, y;
            
            Console.WriteLine("Digite dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y)
            {
                if (x>y)
                {
                    Console.WriteLine("Decrescente!");
                } else Console.WriteLine("Crescente!"); 
                Console.WriteLine("Digite outros dois numeros: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
            
        }
    }
}*/