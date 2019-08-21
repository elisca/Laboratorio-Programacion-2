using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int alturaPiramide = 1, anchoPiramide = 1, filaActual = 1, margenIzquierdo=0;
            string texto = "*", txtMargenIzquierdo="";

            do
            {
                Console.Write("Alto de pirámide: ");
            } while (!int.TryParse(Console.ReadLine(), out alturaPiramide) || alturaPiramide <= 0);

            for (filaActual = 1; filaActual <= alturaPiramide; filaActual++)
            {
                if (filaActual > 1)
                {
                    texto = string.Concat(texto, "**");
                }

                txtMargenIzquierdo = "";
                for (margenIzquierdo = (alturaPiramide - filaActual) * 2; margenIzquierdo > 0; margenIzquierdo -= 2)
                {
                    txtMargenIzquierdo = string.Concat(txtMargenIzquierdo, " ");
                }
                Console.WriteLine("{0}{1}",txtMargenIzquierdo,texto);
            }
            Console.ReadKey();
        }
    }
}
