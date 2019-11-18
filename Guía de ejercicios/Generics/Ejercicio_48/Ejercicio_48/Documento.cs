using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    class Documento
    {
        int numero;

        public int Numero
        {
            get { return numero; }
        }

        public Documento():this(0)
        { }

        public Documento(int numero)
        {
            this.numero = numero;
        }
    }
}
