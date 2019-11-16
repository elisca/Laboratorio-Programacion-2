using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class EquipoBasquet:Equipo
    {
        public EquipoBasquet()
        { }

        public EquipoBasquet(string nombre, DateTime fechaCreacion)
        {
            this.Nombre = nombre;
            this.FechaCreacion = fechaCreacion;
        }

        public override string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public override DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
            set
            {
                this.fechaCreacion = value;
            }
        }

        public override string Ficha()
        {
            return this.Nombre + " fundado el " + this.FechaCreacion.ToString();
        }
    }
}
