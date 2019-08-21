using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, numMin=int.MaxValue, numMax=int.MinValue;
            float numsProm = 0;

            do
            {
                Console.Write("Número 1: ");
            }while(!int.TryParse(Console.ReadLine(),out n1));
            BuscarMinimo(n1, ref numMin);
            BuscarMaximo(n1, ref numMax);

            do
            {
                Console.Write("Número 2: ");
            } while (!int.TryParse(Console.ReadLine(), out n2));
            BuscarMinimo(n2, ref numMin);
            BuscarMaximo(n2, ref numMax);

            do
            {
                Console.Write("Número 3: ");
            } while (!int.TryParse(Console.ReadLine(), out n3));
            BuscarMinimo(n3, ref numMin);
            BuscarMaximo(n3, ref numMax);

            do
            {
                Console.Write("Número 4: ");
            } while (!int.TryParse(Console.ReadLine(), out n4));
            BuscarMinimo(n4, ref numMin);
            BuscarMaximo(n4, ref numMax);

            do
            {
                Console.Write("Número 5: ");
            } while (!int.TryParse(Console.ReadLine(), out n5));
            BuscarMinimo(n5, ref numMin);
            BuscarMaximo(n5, ref numMax);

            numsProm = (n1 + n2 + n3 + n4 + n5) / 5;

            Console.Clear();

            Console.WriteLine("Resultados:");
            Console.WriteLine("Secuencia de números: {0}-{1}-{2}-{3}-{4}",n1,n2,n3,n4,n5);
            Console.WriteLine("Número mínimo: {0}", numMin);
            Console.WriteLine("Número máximo: {0}", numMax);
            Console.WriteLine("Número promedio: {0}", numsProm);
            Console.ReadKey();
        }

        static void BuscarMinimo(int numero, ref int valMin)
        {
            if (numero < valMin)
            {
                valMin = numero;
            }
        }

        static void BuscarMaximo(int numero, ref int valMax)
        {
            if (numero > valMax)
            {
                valMax = numero;
            }
        }
    }
}
