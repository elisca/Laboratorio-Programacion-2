using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        public Cliente Cliente
        {
            get
            {
                return this.clientes.ElementAt(PuestoAtencion.NumeroActual-1);
            }
            set
            {
                bool clienteAgregado = this + value;
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            foreach (Cliente auxCliente in n.clientes)
            {
                if (auxCliente == c)
                {
                    return false;
                }
            }
            n.clientes.Enqueue(c);
            return true;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool clienteExistente = false;

            foreach (Cliente auxCliente in n.clientes)
            {
                if (auxCliente == c)
                {
                    clienteExistente = true;
                    break;
                }
            }
            return clienteExistente;
        }
    }
}
