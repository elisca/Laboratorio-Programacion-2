using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Lapiz : IAcciones
    {
        float tamanioMina;

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper lapizWrapper = new EscrituraWrapper(texto);
            int longitudTexto = texto.Length;
            float reduccionMina = longitudTexto * 0.1f;

            this.UnidadesDeEscritura = this.UnidadesDeEscritura - reduccionMina;
            
            return lapizWrapper;
        }

        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format("Tipo: {0} Color: {1} Nivel de Mina: {2}", this.GetType().ToString(), this.Color.ToString(), this.Mina.ToString());
        }
    }
}
