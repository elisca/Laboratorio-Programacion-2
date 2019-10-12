using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{
    public class PuestoAtencion
    {
        public enum Puesto
        { 
            Caja1,
            Caja2
        }

        static int numeroActual;
        Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual++;
                return PuestoAtencion.numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1000);
            return true;
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
    }
}
