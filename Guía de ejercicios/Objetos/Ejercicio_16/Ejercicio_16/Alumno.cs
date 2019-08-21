using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1 = 0, nota2 = 0;
        private float notaFinal = 0;
        public string apellido = null, nombre = null;
        public int legajo = 0;
        Random rndNotaFinal = new Random();

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = (float)(this.rndNotaFinal.NextDouble()*10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            if (notaUno >= 1 || notaUno <= 10)
            {
                this.nota1 = notaUno;
            }
            else
            {
                this.nota1 = 0;
            }

            if (notaDos >= 1 || notaDos <= 10)
            {
                this.nota2 = notaDos;
            }
            else
            {
                this.nota2 = 0;
            }
        }

        public string Mostrar()
        {
            StringBuilder datosAlumno = new StringBuilder();
            string devDatosAlumno = null;

            datosAlumno.AppendLine("---------------------------------------------");
            datosAlumno.AppendFormat("Alumno: {0} {1} Legajo: {2}\n", this.nombre, this.apellido, this.legajo);
            datosAlumno.AppendLine("Nota 1: " + this.nota1 + " Nota 2: " + this.nota2);

            if (this.notaFinal != -1)
            {
                datosAlumno.AppendLine("Nota final (random): " + this.notaFinal);
            }
            else
            {
                datosAlumno.AppendLine("Alumno desaprobado");
            }
            datosAlumno.AppendLine("---------------------------------------------");

            devDatosAlumno = datosAlumno.ToString();

            return devDatosAlumno;
        }
    }
}
