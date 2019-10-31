using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        StreamReader sr;
        StreamWriter sw;

        public bool Guardar(string ruta, string objeto)
        {
            if (ruta != null && ruta != "" && objeto != null && objeto != "")
            {
                using (sw = new StreamWriter(ruta))
                {
                    sw.Write(objeto);
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool GuardarComo(string ruta, string objeto)
        {
            if (ruta != null && ruta != "" && objeto != null)
            {
                this.Guardar(ruta, objeto);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Leer(string ruta)
        {
            string contenido;

            if (ruta != null && ruta != "" && this.ValidarArchivo(ruta, true))
            {
                using (sr = new StreamReader(ruta))
                {
                    contenido = sr.ReadToEnd();
                }
                
                return contenido;
            }
            else
            {
                return null;
            }
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool archivoExistente;

            try
            {
                if (validaExistencia)
                {
                    archivoExistente = base.ValidarArchivo(ruta, validaExistencia);

                    if (ruta.EndsWith(".txt"))
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un txt.");
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
            }
            finally
            {
            }
        }
    }
}
