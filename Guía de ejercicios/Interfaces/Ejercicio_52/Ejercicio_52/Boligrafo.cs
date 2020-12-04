using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Boligrafo : IAcciones
    {
        ConsoleColor colorTinta;
        float tinta;

        public ConsoleColor Color
        {
            get
            {
                return colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = unidades;
            this.Color = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper boligrafoWrapper = new EscrituraWrapper(texto);
            int longitudTexto = texto.Length;
            float reduccionTinta = longitudTexto * 0.3f;

            this.UnidadesDeEscritura = this.UnidadesDeEscritura - reduccionTinta;

            return boligrafoWrapper;
        }

        public bool Recargar(int unidades)
        {
            bool recargaOK = true;

            if (unidades > 0)
            {
                this.UnidadesDeEscritura += unidades;
            }
            else
            {
                recargaOK = false;
            }
            
            return recargaOK;
        }

        public override string ToString()
        {
            return string.Format("Tipo: {0} Color: {1} Nivel de Tinta: {2}", this.GetType().ToString(), this.Color.ToString(), this.tinta.ToString());
        }
    }
}
