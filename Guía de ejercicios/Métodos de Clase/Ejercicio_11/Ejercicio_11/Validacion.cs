using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11
{
    internal class Validacion
    {
        internal static bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
