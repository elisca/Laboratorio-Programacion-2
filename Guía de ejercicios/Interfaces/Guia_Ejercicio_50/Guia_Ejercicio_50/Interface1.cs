using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Ejercicio_50
{
    interface IGuardar<T, V>
    {
        bool Guardar(T obj);

        V Leer();
    }
}
