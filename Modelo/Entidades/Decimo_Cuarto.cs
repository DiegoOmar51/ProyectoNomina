﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Decimo_Cuarto
    {
        public int Decimo_CuartoId { get; set; }
        //Relacion con personal 
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }

        public string meses { get; set; }
        public double total { get; set; }

        
    }
}
