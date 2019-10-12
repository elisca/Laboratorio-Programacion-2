using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        private float costo;

        public float CostoLlamada
        {
            get 
            {
                return this.CalcularCosto(); 
            }
        }

        private float CalcularCosto()
        {
            float costoTotal = this.costo * this.Duracion;

            return costoTotal;
        }

        public Local(Llamada llamada, float costo):this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo):base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Costo de llamada: ${0}", this.CostoLlamada);

            return sb.ToString();
        }
    }
}
