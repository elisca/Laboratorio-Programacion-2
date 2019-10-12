using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public enum Colores
    { 
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }

    public class Automovil:VehiculoTerrestre
    {
        short cantidadMarchas;
        int cantidadPasajeros;

        public Automovil(short cantRuedas, short cantPuertas, Colores color, short cantMarchas, int cantPasajeros):base(cantRuedas, cantPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantPasajeros;
        }

        public override string MostrarCaracteristicas()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarCaracteristicas());
            sb.AppendLine("Cantidad de marchas: " + this.cantidadMarchas);
            sb.AppendLine("Cantidad de pasajeros: " + this.cantidadPasajeros);

            return sb.ToString();
        }
    }
}
