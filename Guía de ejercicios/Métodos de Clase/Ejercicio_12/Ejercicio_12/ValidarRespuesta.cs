using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    internal class ValidarRespuesta
    {
        internal static bool ValidaS_N(char c)
        {
            if (c == 'S' || c == 's')
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
