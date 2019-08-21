using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro euros = new Euro(1);
            Dolar dolares = new Dolar(2);
            Pesos pesos = new Pesos(3);

            Console.WriteLine("Cantidades de dinero disponibles y tipo de cambio respecto al Dólar:");
            Console.WriteLine("Cantidad de Euros: {0} Cotización: {1}", euros.GetCantidad(), Euro.GetCotizacion());
            Console.WriteLine("Cantidad de Dolares: {0} Cotización: {1}", dolares.GetCantidad(), dolares.GetCotizacion());
            Console.WriteLine("Cantidad de Pesos: {0} Cotización: {1}\n", pesos.GetCantidad(), Pesos.GetCotizacion());

            Console.WriteLine("Cantidad de dinero disponible y conversión a los otros tipos de cambio:");
            Console.WriteLine("Cantidad de Euros: {0} Dolares: {1} Pesos: {2}", euros.GetCantidad(), ((Dolar)euros).GetCantidad(), ((Pesos)euros).GetCantidad());
            Console.WriteLine("Cantidad de Dolares: {0} Euros: {1} Pesos: {2}", dolares.GetCantidad(), ((Euro)dolares).GetCantidad(), ((Pesos)dolares).GetCantidad());
            Console.WriteLine("Cantidad de Pesos: {0} Euros: {1} Dolares: {2}\n", pesos.GetCantidad(), ((Euro)pesos).GetCantidad(), ((Dolar)pesos).GetCantidad());

            Console.WriteLine("Sumando 10 euros: {0}", euros + 10);
            Console.WriteLine("Sumando 20 dólares: {0}", dolares + 20);
            Console.WriteLine("Sumando 5 pesos: {0}", pesos + 5);

            Console.ReadKey();
        }
    }
}
