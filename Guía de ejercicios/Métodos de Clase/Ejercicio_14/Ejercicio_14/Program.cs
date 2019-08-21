using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double datoA=0, datoB=0, areaCuadrado=0, areaTriangulo=0, areaCirculo=0;

            Console.WriteLine("Cálculo de área de figuras.");
            do
            {
                Console.Write("Ingrese cateto de un cuadrado: ");
            } while (!double.TryParse(Console.ReadLine(), out datoA) || datoA<=0);
            areaCuadrado = CalculoDeArea.CalcularCuadrado(datoA);

            do
            {
                Console.Write("Ingrese base de un triángulo: ");
            } while (!double.TryParse(Console.ReadLine(), out datoA) || datoA <= 0);
            
            do
            {
                Console.Write("Ingrese altura de un triángulo: ");
            } while (!double.TryParse(Console.ReadLine(), out datoB) || datoB <= 0);
            areaTriangulo = CalculoDeArea.CalcularTriangulo(datoA, datoB);

            do
            {
                Console.Write("Ingrese radio de un círculo: ");
            } while (!double.TryParse(Console.ReadLine(), out datoA) || datoA <= 0);
            areaCirculo = CalculoDeArea.CalcularCirculo(datoA);

            Console.Clear();
            Console.WriteLine("Área del cuadrado: {0}", areaCuadrado);
            Console.WriteLine("Área del triángulo: {0}", areaTriangulo);
            Console.WriteLine("Área del círculo: {0}", areaCirculo);

            Console.ReadKey();
        }
    }
}
