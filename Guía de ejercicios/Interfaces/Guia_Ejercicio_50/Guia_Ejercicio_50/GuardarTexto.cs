using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Ejercicio_50
{
    class GuardarTexto<T, V> : IGuardar<T, V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            return Convert.ChangeType("Texto leído", typeof(V));
        }
    }
}
