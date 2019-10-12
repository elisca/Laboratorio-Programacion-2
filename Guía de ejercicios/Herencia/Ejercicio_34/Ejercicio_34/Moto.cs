using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Moto:VehiculoTerrestre
    {
        short cilindrada;

        public Moto(short cantRuedas, short cantPuertas, Colores color, short cc):base(cantRuedas, cantPuertas, color)
        {
            this.cilindrada = cc;
        }

        public override string MostrarCaracteristicas()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarCaracteristicas());
            sb.AppendLine("Cilindrada: " + this.cilindrada);

            return sb.ToString();
        }
    }
}
