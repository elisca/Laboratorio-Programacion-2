using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_29
{
    public class DirectorTecnico:Persona
    {
        DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private DirectorTecnico(string nombre):base(nombre)
        { }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento):this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Fecha de nacimiento: " + this.FechaNacimiento);

            return sb.ToString();
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return ((dt1.FechaNacimiento == dt2.FechaNacimiento) && (dt1.Nombre == dt2.Nombre));
        }
    }
}
