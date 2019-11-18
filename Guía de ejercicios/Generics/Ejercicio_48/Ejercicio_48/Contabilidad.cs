﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    class Contabilidad<T, U> where T:Documento where U:Documento, new()
    {
        List<T> egresos;
        List<U> ingresos;

        public List<T> Egresos
        {
            get { return egresos; }
        }

        public List<U> Ingresos
        {
            get { return ingresos; }
        }

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            if (egreso != null)
            {
                c.egresos.Add(egreso);
            }

            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (ingreso != null)
            {
                c.ingresos.Add(ingreso);
            }

            return c;
        }
    }
}
