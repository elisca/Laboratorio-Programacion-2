using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[0] = "Hola, esta es la primera página del libro.";
            libro[10] = "En esta segunda página, agregamos un prólogo para resumir de que tratará el contenido.";
            libro[20] = "Ya en la tercera página comenzamos una introducción al tema a desarrollar.";

            Console.WriteLine("Se agregaron tres páginas al libro.");

            Console.WriteLine("Intento leer contenido de la primera página: {0}", libro[0]);
            Console.WriteLine("Intento leer contenido de la segunda página: {0}", libro[1]);
            Console.WriteLine("Intento leer contenido de la tercera página: {0}", libro[2]);
            Console.WriteLine("Intento leer contenido de la cuarta página (inexistente): {0}", libro[3]);

            Console.ReadKey();
        }
    }
}
