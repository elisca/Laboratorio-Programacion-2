using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(12, 2, Colores.Blanco, 5, 48000);
            Automovil automovil = new Automovil(4, 5, Colores.Rojo, 5, 5);
            Moto moto = new Moto(2, 0, Colores.Azul, 200);

            Console.WriteLine("CAMION - CARACTERISTICAS");
            Console.WriteLine("{0}", camion.MostrarCaracteristicas());
            Console.WriteLine("AUTOMOVIL - CARACTERISTICAS");
            Console.WriteLine("{0}", automovil.MostrarCaracteristicas());
            Console.WriteLine("MOTO - CARACTERISTICAS");
            Console.WriteLine("{0}", moto.MostrarCaracteristicas());

            Console.ReadKey();
        }
    }
}
