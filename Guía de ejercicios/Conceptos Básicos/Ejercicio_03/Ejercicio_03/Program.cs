using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numUsuario, i=1, j=1;
            bool esPrimo=true;

            Console.WriteLine("Búsqueda de números primos.");

            do
            {
                Console.Write("Ingrese número límite a buscar (mayores a 0): ");
            } while (!uint.TryParse(Console.ReadLine(), out numUsuario) || numUsuario < 1);

            while (i <= numUsuario)
            {
                j = 1;
                esPrimo=true;
                while(j<=i)
                {
                    if(i%j==0 && j!=1 && j!=i)
                    {
                        esPrimo=false;
                    }
                    j++;
                }

                if(esPrimo)
                {
                    Console.Write("{0};",i);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
