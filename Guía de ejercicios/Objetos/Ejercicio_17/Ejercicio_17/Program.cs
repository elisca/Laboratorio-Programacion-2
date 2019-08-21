using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ejercicio_17_Boligrafo;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string pintar=null;
            Boligrafo boliAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boliRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine("Bolígrafo azul-Test:");
            Console.WriteLine("Nivel de tinta inicial debe ser 100: {0}", boliAzul.GetTinta());
            Console.WriteLine("Color de tinta debe ser azul: {0}", boliAzul.GetColor().ToString());
            Console.WriteLine("Gastar 50...");
            Console.WriteLine("Escribir el gasto de tinta y en el color indicado: ");
            boliAzul.Pintar(50, out pintar);
            Console.WriteLine("Nivel de tinta debe ser 50: {0}", boliAzul.GetTinta());
            boliAzul.Recargar();
            Console.WriteLine("Nivel de tinta debe ser 100, hubo recarga: {0}", boliAzul.GetTinta());
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Bolígrafo rojo-Test:");
            Console.WriteLine("Nivel de tinta inicial debe ser 50: {0}", boliRojo.GetTinta());
            Console.WriteLine("Color de tinta debe ser rojo: {0}", boliRojo.GetColor().ToString());
            Console.WriteLine("Gastar 30...");
            Console.WriteLine("Escribir el gasto de tinta y en el color indicado: ");
            boliRojo.Pintar(30, out pintar);
            Console.WriteLine("Nivel de tinta debe ser 20: {0}", boliRojo.GetTinta());
            boliRojo.Recargar();
            Console.WriteLine("Nivel de tinta debe ser 100, hubo recarga: {0}", boliRojo.GetTinta());
            Console.ReadKey();
        }
    }
}
