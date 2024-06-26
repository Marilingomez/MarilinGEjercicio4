﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarilinGEjercicio4
{
    internal class Persona
    {
        public int Documento {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public Telefono Telefono { get; set;}

        public ActualizarCon(Persona datos)
        {
            Documento = datos.Documento;
            Nombre=datos.Nombre;
            Apellido=datos.Apellido;
            Telefono.ActualizarCon(datos.Telefono);
        }

    }
}
