using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumnoEzequiel = new Alumno();
            Alumno alumnoAriel = new Alumno();
            Alumno alumnoAlejandro = new Alumno();

            alumnoEzequiel.nombre = "Ezequiel";
            alumnoEzequiel.apellido = "Lisca";
            alumnoEzequiel.legajo = 27;
            alumnoEzequiel.Estudiar(4, 10);
            alumnoEzequiel.CalcularFinal();

            alumnoAriel.nombre = "Ariel";
            alumnoAriel.apellido = "Lisca";
            alumnoAriel.legajo = 23;
            alumnoAriel.Estudiar(9, 10);
            alumnoAriel.CalcularFinal();

            alumnoAlejandro.nombre = "Alejandro";
            alumnoAlejandro.apellido = "Lisca";
            alumnoAlejandro.legajo = 27;
            alumnoAlejandro.Estudiar(3, 7);
            alumnoAlejandro.CalcularFinal();

            Console.WriteLine(alumnoEzequiel.Mostrar());
            Console.WriteLine(alumnoAriel.Mostrar());
            Console.WriteLine(alumnoAlejandro.Mostrar());

            Console.ReadKey();
        }
    }
}
