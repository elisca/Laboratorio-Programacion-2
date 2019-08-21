using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio = 0, anioFinal = 0, anioActual = 0;

            Console.WriteLine("Búsqueda de años bisiestos.");
            
            do
            {
                Console.Write("Ingrese un año de comienzo del rango a buscar: ");
            }while(!int.TryParse(Console.ReadLine(),out anioInicio));
            
            do
            {
                Console.Write("Ingrese un año de final del rango a buscar: ");
            }while(!int.TryParse(Console.ReadLine(),out anioFinal));

            for(anioActual=anioInicio; anioActual<=anioFinal; anioActual++)
            {
                if(anioActual%4==0 && (anioActual%100!=0 || (anioActual%100==0  && anioActual%400==0)))
                {
                    Console.Write("{0};",anioActual);
                }
            }
            Console.ReadKey();
        }
    }
}
