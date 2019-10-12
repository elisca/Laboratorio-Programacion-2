using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Competencia: Abu Dhabi");
            sb.AppendLine("Cantidad de competidores: " + this.cantidadCompetidores);
            sb.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);

            return sb.ToString();
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c.competidores.Contains(a))
            {
                c.competidores.Remove(a);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random rndCombustible = new Random();

            if ((c.competidores.Count() < c.cantidadCompetidores) && (c.cantidadCompetidores > 0) && (c != a))
            {
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCantCombustible((short)rndCombustible.Next(15,100));
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return (c.competidores.Contains(a));
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
