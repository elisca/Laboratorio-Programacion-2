using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> libroContable = new Contabilidad<Factura, Recibo>();

            Recibo recibo00 = new Recibo();
            Recibo recibo01 = new Recibo(10);
            Factura factura00 = new Factura(1);

            libroContable += recibo00;
            libroContable += recibo01;
            libroContable += factura00;

            Console.WriteLine("IMPRIMIENDO RECIBOS...");
            foreach (Documento auxDocumento in libroContable.Ingresos)
            {
                Console.WriteLine("\t{0}", auxDocumento.Numero);
            }

            Console.WriteLine("IMPRIMIENDO FACTURAS...");
            foreach (Documento auxDocumento in libroContable.Egresos)
            {
                Console.WriteLine("\t{0}", auxDocumento.Numero);
            }

            Console.ReadKey();
        }
    }
}
