using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDecimal;
            string numeroBinario;

            do
            {
                Console.Write("Número decimal a convertir: ");
            }while(!double.TryParse(Console.ReadLine(), out numeroDecimal));

            Console.WriteLine("Número binario: {0}", Conversor.DecimalBinario(numeroDecimal).ToString());
            Console.Write("Número binario a convertir: ");
            numeroBinario = Console.ReadLine();

            Console.WriteLine("Número decimal: {0}", Conversor.BinarioDecimal(numeroBinario));
            Console.ReadKey();
        }
    }
}
