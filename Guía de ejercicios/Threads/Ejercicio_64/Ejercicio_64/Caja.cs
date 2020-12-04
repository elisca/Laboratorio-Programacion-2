using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    class Caja
    {
        List<string> filaClientes;
        
        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public void AtenderClientes()
        {
            foreach (string auxCliente in this.FilaClientes)
            {
                Console.WriteLine("Cliente: {0} Caja: {1}", auxCliente, Thread.CurrentThread.Name);
                Thread.Sleep(20); //2000
            }
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }
    }
}
