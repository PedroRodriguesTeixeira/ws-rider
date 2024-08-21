/*using System;
using System.Globalization;

namespace ws_rider.exercicios
{
    public class retangulo
    {
        
        //Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor
//da área, perímetro e diagonal deste retângulo, com quatro casas decimais, conforme exemplos.
        
        public static void Main(string[] args)
        {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            double b, h, area,  perimetro, diagonal;
            
            Console.Write("Digite base do retangulo: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite altura do retangulo: ");
            h = double.Parse(Console.ReadLine(), CI);

            area = b * h;
            perimetro = 2 * (b + h);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(h, 2.0));
            
            Console.WriteLine("Area = " + area.ToString("F4", CI));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CI));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CI));


        }
    }
}*/