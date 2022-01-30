using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Decimo_Tercero
    {
        public int Decimo_TerceroId { get; set; }
        //Relacion con personal 
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }
        public DateTime finicio { get; set; }
        public DateTime ffinal { get; set; }
        public String meses { get; set; }
        public double total { get; set; }
        

    }
}
