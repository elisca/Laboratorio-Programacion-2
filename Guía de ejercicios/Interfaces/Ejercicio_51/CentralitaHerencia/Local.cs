using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float costo;
        string rutaDeArchivo;

        public string RutaDeArchivo
        {
            get
            {
                return rutaDeArchivo;
            }
            set
            {
                rutaDeArchivo = value;
            }
        }

        public override float CostoLlamada
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

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public Local(Llamada llamada, float costo):this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo):base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Llamada Local:\n");
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Costo de llamada: ${0}", this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Local Leer()
        {
            throw new NotImplementedException();
        }
    }
}
