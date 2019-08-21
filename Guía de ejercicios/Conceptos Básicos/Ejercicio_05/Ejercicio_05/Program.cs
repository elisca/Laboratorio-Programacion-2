using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numLimite = 0, acumIzquierda = 0, acumDerecha = 0, j=0;

            Console.WriteLine("Búsqueda de centros numéricos.");
            
            do
            {
                Console.WriteLine("Número hasta el que desea buscar: ");
            }while(!uint.TryParse(Console.ReadLine(), out numLimite) || numLimite < 2);
            
            for (uint numCentro = 2; numCentro <= numLimite; numCentro++)
            {
                acumIzquierda = 0;
                acumDerecha = 0;
                for (uint i = 1; i < numCentro; i++)
                {
                    acumIzquierda += i;
                }

                j = numCentro + 1;
                do
                {
                    acumDerecha += j;
                    j++;
                } while (acumDerecha < acumIzquierda);

                if (acumDerecha == acumIzquierda)
                {
                    Console.Write("{0};", numCentro);
                }
            }
            Console.ReadKey();
        }
    }
}
