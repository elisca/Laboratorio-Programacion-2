using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();
            Negocio n = new Negocio(c1, c2);

            n.Clientes.Add("Ezequiel");
            n.Clientes.Add("Mariela");
            n.Clientes.Add("Alejandro");
            n.Clientes.Add("Rocio");
            n.Clientes.Add("Jonathan");
            n.Clientes.Add("Belén");

            Thread tNegocio = new Thread(n.AsignarCaja);
            Thread tCaja1 = new Thread(c1.AtenderClientes);
            tCaja1.Name = "Caja1";
            Thread tCaja2 = new Thread(c2.AtenderClientes);
            tCaja2.Name = "Caja2";

            tNegocio.Start();
            tNegocio.Join();
            tCaja1.Start();
            tCaja2.Start();

            Console.ReadKey();
        }
    }
}
