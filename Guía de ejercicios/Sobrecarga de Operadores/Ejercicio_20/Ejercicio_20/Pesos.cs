using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billetes
{
    class Pesos
    {
        private double cantidad = 0;
        private static float cotizRespectoDolar = 0;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 0.026f;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion):this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Pesos p)
        {
            double cantDolares = p.GetCantidad() * Pesos.GetCotizacion() ;
            Dolar auxD = new Dolar(cantDolares);
            return auxD;
        }

        public static explicit operator Euro(Pesos p)
        {
            double cantEuros = p.GetCantidad()*Pesos.GetCotizacion()/Euro.GetCotizacion();
            Euro auxE = new Euro(cantEuros);
            return auxE;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static implicit operator Pesos(double d)
        {
            Pesos auxP = new Pesos(d);
            return auxP;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Dolar operator -(Pesos p, Dolar d)
        {
            Dolar auxD = (Dolar)p;
            Dolar resultado = auxD.GetCantidad() - d.GetCantidad();
            return resultado;
        }

        public static Dolar operator -(Pesos p, Euro e)
        {
            Dolar auxDP = (Dolar)p;
            Dolar auxDE = (Dolar)e;
            Dolar resultado = auxDP.GetCantidad() - auxDE.GetCantidad();
            return resultado;
        }

        public static Dolar operator +(Pesos p, Dolar d)
        {
            Dolar auxD = (Dolar)p;
            Dolar resultado = auxD.GetCantidad() + d.GetCantidad();
            return resultado;
        }

        public static Dolar operator +(Pesos p, Euro e)
        {
            Dolar auxDP = (Dolar)p;
            Dolar auxDE = (Dolar)e;
            Dolar resultado = auxDP.GetCantidad() + auxDE.GetCantidad();
            return resultado;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            Dolar auxD = (Dolar)p;
            if (auxD.GetCantidad() == d.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            Euro auxE = (Euro)p;
            if (auxE.GetCantidad() == e.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            if (p1.GetCantidad() == p2.GetCantidad())
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
