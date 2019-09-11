using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public static void SetCotizacion(double cotizacion)
        {
            Dolar.cotizRespectoDolar = (float)cotizacion;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion):this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            double cantEuros = d.GetCantidad() / Euro.GetCotizacion();
            Euro auxE = new Euro(cantEuros);
            return auxE;
        }

        public static explicit operator Pesos(Dolar d)
        { 
            double cantPesos = d.GetCantidad() / Pesos.GetCotizacion();
            Pesos auxP = new Pesos(cantPesos);
            return auxP;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar; ;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar auxD = new Dolar(d);
            return auxD;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar auxD = (Dolar)e;
            Dolar resultado = d.GetCantidad() - auxD.GetCantidad();
            return resultado;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar auxP = (Dolar)p;
            Dolar resultado = d.GetCantidad() - auxP.GetCantidad();
            return resultado;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar auxD = (Dolar)e;
            Dolar resultado = d.GetCantidad() + auxD.GetCantidad();
            return resultado;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar auxP = (Dolar)p;
            Dolar resultado = d.GetCantidad() + auxP.GetCantidad();
            return resultado;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            Euro auxE = (Euro)d;
            if (auxE.GetCantidad() == e.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            Pesos auxP = (Pesos)d;
            if (auxP.GetCantidad() == p.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1.GetCantidad() == d2.GetCantidad())
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
