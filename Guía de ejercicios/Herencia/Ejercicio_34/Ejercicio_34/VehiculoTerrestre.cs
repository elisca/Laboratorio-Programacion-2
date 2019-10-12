using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public abstract class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        public VehiculoTerrestre(short cantRuedas, short cantPuertas, Colores color)
        {
            this.cantidadRuedas = cantRuedas;
            this.cantidadPuertas = cantPuertas;
            this.color = color;
        }

        public virtual string MostrarCaracteristicas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de ruedas: " + this.cantidadRuedas);
            sb.AppendLine("Cantidad de puertas: " + this.cantidadPuertas);
            sb.AppendLine("Color: " + this.color);

            return sb.ToString();
        }
    }
}
