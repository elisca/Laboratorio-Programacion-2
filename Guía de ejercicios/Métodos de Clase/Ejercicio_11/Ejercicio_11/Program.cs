using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, numMin = int.MaxValue, numMax = int.MinValue, numsProm=0;

            for (int i = 1; i <= 10; i++)
            { 
                do
                {
                    Console.Write("Ingrese un número entero entre -100 y 100: ");
                }while(!int.TryParse(Console.ReadLine(), out numero) || !Validacion.Validar(numero,-100,100));

                if (numero < numMin)
                {
                    numMin = numero;
                }

                if (numero > numMax)
                {
                    numMax = numero;
                }

                numsProm += numero;
            }
            numsProm /= 10;

            Console.Clear();

            Console.WriteLine("Número mínimo: {0} Número máximo: {1} Número promedio: {2}", numMin, numMax, numsProm);
            Console.ReadKey();
        }
    }
}
