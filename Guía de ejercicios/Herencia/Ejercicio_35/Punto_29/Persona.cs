using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_29
{
    public abstract class Persona
    {
        long dni;
        string nombre;

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Persona:");
            sb.AppendLine("DNI:" + this.Dni);
            sb.AppendLine("Nombre:" + this.Nombre);

            return sb.ToString();
        }

        public Persona(long dni, string nombre):this(nombre)
        { 
            this.Dni = dni;
        }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
