using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas = 0;

        public Sumador():this(0)
        { }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            long resultado = a + b;
            this.cantidadSumas++;
            return resultado;
        }

        public string Sumar(string a, string b)
        {
            string resultado = string.Concat(a, b);
            this.cantidadSumas++;
            return resultado;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            if ((int)s1 == (int)s2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long resultado;
            resultado = (int)s1 + (int)s2;
            return resultado;
        }
    }
}
