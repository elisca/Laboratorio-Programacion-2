using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio cgp = new Negocio("CGP");
            PuestoAtencion pAt = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            Cliente[] arrayClientes = new Cliente[5];
            arrayClientes[0] = new Cliente(10, "Alberto");
            arrayClientes[1] = new Cliente(11, "Beto");
            arrayClientes[2] = new Cliente(12, "Carlos");
            arrayClientes[3] = new Cliente(13, "Daniel");
            arrayClientes[4] = new Cliente(14, "Ernesto");

            Console.WriteLine("Nota: Crear la propiedad \"ClientesPendientes\" de la clase \"Negocio\".");

            foreach (Cliente auxCli in arrayClientes)
            {
                if (cgp + auxCli)
                {
                    Console.WriteLine("Agregado a la cola de atención {0}", auxCli.Nombre);
                }
                else
                {
                    Console.WriteLine("No se pudo agregar a la cola de atención a {0}", auxCli.Nombre);
                }
            }

            for (int i = 0; i < arrayClientes.Count(); i++)
            {
                if (~cgp)
                {
                    Console.WriteLine("Se pudo atender a un cliente.");
                }
                else
                {
                    Console.WriteLine("No se pudo atender a un cliente.");
                }
            }
            Console.ReadKey();
        }
    }
}
