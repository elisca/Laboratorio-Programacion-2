using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public abstract string Nombre
        {
            get;
            set;
        }

        public abstract DateTime FechaCreacion
        {
            get;
            set;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return (e1.Nombre == e2.Nombre && e1.fechaCreacion == e2.fechaCreacion);
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public abstract string Ficha();
    }
}
