using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1
    {
        short cantidadCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Escuderia: " + this.escuderia + " Numero: " + this.numero + " En competencia: " + this.GetEnCompetencia() + " Vueltas restantes: " + this.GetVueltasRestantes() + " Combustible restante: " + this.GetCantCombustible());

            return sb.ToString();
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ((a1.numero == a2.numero) && (a1.escuderia == a2.escuderia));
        }

        public short GetCantCombustible()
        {
            return this.cantidadCombustible;
        }

        public bool SetCantCombustible(short combustible)
        {
            if (combustible >= 0)
            {
                this.cantidadCombustible = combustible;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public bool SetVueltasRestantes(short vueltasRestantes)
        {
            if (vueltasRestantes >= 0)
            {
                this.vueltasRestantes = vueltasRestantes;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
