using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    public class PuntoDat:Archivo, IArchivos<PuntoDat>
    {
        FileStream fs;
        BinaryFormatter bf;
        string contenido;

        public string Contenido 
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        public bool Guardar(string ruta, PuntoDat objeto)
        {
            if (ruta != null && ruta != "" && objeto != null && objeto.ValidarArchivo(ruta, true))
            {
                fs = new FileStream(ruta, FileMode.Create);
                bf = new BinaryFormatter();

                bf.Serialize(fs, objeto);
                fs.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            if (ruta != null && ruta != "" && objeto != null)
            {
                fs = new FileStream(ruta, FileMode.CreateNew);
                bf = new BinaryFormatter();

                bf.Serialize(fs, objeto);
                fs.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public PuntoDat Leer(string ruta)
        {
            if (ruta != null && ruta != "" && this.ValidarArchivo(ruta, true))
            {
                fs = new FileStream(ruta, FileMode.Open);
                bf = new BinaryFormatter();

                this.Contenido = bf.Deserialize(fs).ToString();
                fs.Close();
                return this;
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

                    if (ruta.EndsWith(".dat"))
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un dat.");
                    }
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
            }
            finally
            {
            }
        }
    }
}
