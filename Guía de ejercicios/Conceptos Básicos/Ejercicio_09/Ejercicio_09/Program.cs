using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int alturaPiramide=1, anchoPiramide=1, filaActual=1;
            string texto="*";

            do
            {
                Console.Write("Alto de pirámide: ");
            } while (!int.TryParse(Console.ReadLine(), out alturaPiramide) || alturaPiramide<=0);

            for (filaActual = 1; filaActual <= alturaPiramide; filaActual++)
            {
                if (filaActual > 1)
                {
                    texto = string.Concat(texto, "**");
                }
                Console.WriteLine(texto);
            }
            Console.ReadKey();
        }
    }
}
