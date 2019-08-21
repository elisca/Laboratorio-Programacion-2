using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, num2, num3;
            bool error=false;

            Console.WriteLine("Calcular cuadrado y cubo de un número.");
            do
            {
                Console.Write("Número: ");

                if(!double.TryParse(Console.ReadLine(), out num) || num <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    error=true;
                }
                else
                {
                    error=false;
                }
            } while (error==true);

            num2 = Math.Pow(num, 2);
            num3 = Math.Pow(num, 3);

            Console.Clear();
            
            Console.WriteLine("Resultado:");
            Console.WriteLine("Número: {0} Cuadrado: {1} Cubo: {2}", num, num2, num3);
            Console.ReadKey();
        }
    }
}
