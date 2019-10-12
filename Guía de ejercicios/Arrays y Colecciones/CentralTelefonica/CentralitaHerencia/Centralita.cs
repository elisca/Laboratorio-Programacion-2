using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get 
            {
                return this.listaDeLlamadas; 
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float recaudacion = 0;

            foreach (Llamada auxLlamada in this.Llamadas)
            {
                switch (tipo)
                { 
                    case TipoLlamada.Local:
                        if (auxLlamada is Local)
                        {
                            recaudacion += ((Local)auxLlamada).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (auxLlamada is Provincial)
                        {
                            recaudacion += ((Provincial)auxLlamada).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        if (auxLlamada is Local)
                        {
                            recaudacion += ((Local)auxLlamada).CostoLlamada;
                        }
                        else if (auxLlamada is Provincial)
                        {
                            recaudacion += ((Provincial)auxLlamada).CostoLlamada;
                        }
                        break;
                }
            }

            return recaudacion;
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Razon social: {0}\n", this.razonSocial);
            sb.AppendFormat("Ganancia total: ${0}\n", this.GananciasPorTotal);
            sb.AppendFormat("Ganancia por llamadas locales: ${0}\n", this.GananciasPorLocal);
            sb.AppendFormat("Ganancia por llamadas provinciales: ${0}\n", this.GananciasPorProvincial);

            foreach (Llamada auxLlamada in this.Llamadas)
            {
                if (auxLlamada is Local)
                {
                    sb.AppendFormat("{0}", ((Local)auxLlamada).Mostrar());
                }
                else if (auxLlamada is Provincial)
                {
                    sb.AppendFormat("{0}", ((Provincial)auxLlamada).Mostrar());
                }
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
