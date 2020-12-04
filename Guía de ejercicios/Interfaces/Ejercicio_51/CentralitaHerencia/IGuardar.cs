﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    interface IGuardar<T>
    {
        string RutaDeArchivo
        {
            get;
            set;
        }

        bool Guardar();

        T Leer();
    }
}
