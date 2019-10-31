using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IO;

namespace IO
{
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            if (validaExistencia)
            {
                if (File.Exists(ruta))
                {
                    return true;
                }
                else
                {
                    throw new FileNotFoundException("El archivo " + ruta + " no fue encontrado.");
                }
            }
            else
            {
                return false;
            }
        }
    }
}
