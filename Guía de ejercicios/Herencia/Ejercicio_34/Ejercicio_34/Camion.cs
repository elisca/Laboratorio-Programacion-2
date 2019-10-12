using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Camion:VehiculoTerrestre
    {
        short cantidadMarchas;
        int pesoCarga;

        public Camion(short cantRuedas, short cantPuertas, Colores color, short cantMarchas, int pesoCarga):base(cantRuedas, cantPuertas, color)
        {
            this.cantidadMarchas = cantMarchas;
            this.pesoCarga = pesoCarga;
        }

        public override string MostrarCaracteristicas()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarCaracteristicas());
            sb.AppendLine("Cantidad de marchas: " + this.cantidadMarchas);
            sb.AppendLine("Peso de carga (Kg.): " + this.pesoCarga);

            return sb.ToString();
        }
    }
}
