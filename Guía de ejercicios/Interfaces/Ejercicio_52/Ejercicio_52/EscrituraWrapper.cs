using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class EscrituraWrapper
    {
        ConsoleColor color;
        string texto;

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.texto = texto;
            this.color = color;
        }
    }
}
