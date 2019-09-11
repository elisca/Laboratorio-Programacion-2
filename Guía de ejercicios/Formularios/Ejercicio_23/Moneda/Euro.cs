using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billetes
{
    public class Euro
    {
        private double cantidad=0;
        private static float cotizRespectoDolar = 0;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1.16f;
        }

        public static void SetCotizacion(double cotizacion)
        {
            Euro.cotizRespectoDolar = (float)cotizacion;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion):this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro e)
        {
            double cantDolares = e.GetCantidad() * Euro.GetCotizacion();
            Dolar auxD = new Dolar(cantDolares);
            return auxD;
        }

        public static explicit operator Pesos(Euro e)
        {
            double cantPesos = ((Dolar)e).GetCantidad() / Pesos.GetCotizacion();
            Pesos auxP = new Pesos(cantPesos);
            return auxP;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static implicit operator Euro(double d)
        {
            Euro auxE = new Euro(d);
            return auxE;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Dolar operator -(Euro e, Dolar d)
        {
            Dolar auxD = (Dolar)e;
            Dolar resultado = auxD.GetCantidad() - d.GetCantidad();
            return resultado;
        }

        public static Dolar operator -(Euro e, Pesos p)
        {
            Dolar auxDE = (Dolar)e;
            Dolar auxDP = (Dolar)p;
            Dolar resultado = auxDE.GetCantidad() - auxDP.GetCantidad();
            return resultado;
        }

        public static Dolar operator +(Euro e, Dolar d)
        {
            Dolar auxD = (Dolar)e;
            Dolar resultado = auxD.GetCantidad() + d.GetCantidad();
            return resultado;
        }

        public static Dolar operator +(Euro e, Pesos p)
        {
            Dolar auxDE = (Dolar)e;
            Dolar auxDP = (Dolar)p;
            Dolar resultado = auxDE.GetCantidad() + auxDP.GetCantidad();
            return resultado;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            Dolar auxD = (Dolar)e;
            if (auxD.GetCantidad() == d.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            Pesos auxP = (Pesos)e;
            if (auxP.GetCantidad() == p.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            if (e1.GetCantidad() == e2.GetCantidad())
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
