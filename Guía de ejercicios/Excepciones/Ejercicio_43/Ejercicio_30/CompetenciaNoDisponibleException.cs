using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class CompetenciaNoDisponibleException:Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreClase
        {
            get 
            {
                return nombreClase; 
            }
        }

        public string NombreMetodo
        {
            get 
            {
                return nombreMetodo; 
            }
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo):this(mensaje, clase, metodo, null)
        { }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException):base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder datosExcepcion = new StringBuilder();
            Exception auxCnde = this.InnerException;

            datosExcepcion.AppendLine("Excepción en el método " + this.NombreMetodo + " de la clase " + this.NombreClase + ":");
            datosExcepcion.AppendLine(this.Message);

            while (!ReferenceEquals(auxCnde.InnerException, null))
            {
                datosExcepcion.AppendLine("\t" + auxCnde.ToString());
            }
            
            //auxCnde = this.InnerException;

            /*
            auxCnde = this.InnerException;
            do
            {
                datosExcepcion.AppendLine("\t" + auxCnde.ToString());
                auxCnde = auxCnde.InnerException;
            } while (!ReferenceEquals(auxCnde.InnerException, null));
            */
            return datosExcepcion.ToString();
        }
    }
}
