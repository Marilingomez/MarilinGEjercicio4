﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarilinGEjercicio4
{
    internal class Telefono
    {
        public Tipo Tipo { get; set; }
        public int CodPais { get; set; }
        public int CodArea { get; set; }
        public int Numero { get; set; }

        public string Descripcion()
        {
            return $"({Tipo})+{CodPais:00} {CodArea:00}-{Numero:0000}";
     
        
        }

        public void ActualizarCon(Telefono datos)
        {
            Tipo=datos.Tipo ;
            CodPais=datos.CodPais ;
            CodArea=datos.CodArea ;
            Numero=datos.Numero ;
        }
    }
}
