/*using System;

namespace ws_rider.exercicios
{
    public class somaImpares
    {
        
        //Leia 2 valores inteiros X e Y (em qualquer ordem). A seguir, calcule e mostre a soma dos números
        //impares entre eles.
        
        public static void Main(string[] args)
        {

            int x, y, aux, soma = 0;

            Console.WriteLine("Digite dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                aux = x;
                x = y;
                y = aux;
            }

            for (int i = x+1; i < y; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("Soma dos impares: " + soma);

        }
    }
}*/