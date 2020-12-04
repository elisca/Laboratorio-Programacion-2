using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    class Negocio
    {
        Caja caja1;
        Caja caja2;
        List<string> clientes;
        bool asignarCaja1 = true;

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");

            foreach (string auxCliente in this.Clientes)
            {
                if (caja1.FilaClientes.Count <= caja2.FilaClientes.Count)
                {
                    caja1.FilaClientes.Add(auxCliente);
                }
                else
                {
                    caja2.FilaClientes.Add(auxCliente);
                }

                Thread.Sleep(10); //1000
            }

        }

        public Negocio(Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;

            this.clientes = new List<string>();
        }
    }
}
