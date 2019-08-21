using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char r;
            long numsSuma = 0;
            int num=0;

            do
            {
                Console.Clear();
                do
                {
                    Console.Write("Ingrese un número: ");
                }while(!int.TryParse(Console.ReadLine(), out num));
                
                numsSuma += num;

                Console.WriteLine("Total sumado: {0}", numsSuma);

                do
                {
                    Console.Write("¿Continuar? (S/N): ");
                }while(!char.TryParse(Console.ReadLine(), out r));
            }while(ValidarRespuesta.ValidaS_N(r));
        }
    }
}
