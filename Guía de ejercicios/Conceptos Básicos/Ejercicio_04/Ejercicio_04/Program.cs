using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numPerfecto=0, contNumeros=0, acumDivisores=0, i=0;

            Console.WriteLine("Búsqueda de los primeros 4 números perfectos.");

            numPerfecto = 1;
            while (contNumeros < 4)
            {
                i=1;
                acumDivisores = 0;
                while (i < numPerfecto)
                {
                    if (numPerfecto % i == 0)
                    {
                        acumDivisores += i;
                    }
                    i++;
                }

                if (acumDivisores == numPerfecto)
                {
                    contNumeros++;
                    Console.Write("{0};", numPerfecto);
                }
                numPerfecto++;
            }
            Console.ReadKey();
        }
    }
}
