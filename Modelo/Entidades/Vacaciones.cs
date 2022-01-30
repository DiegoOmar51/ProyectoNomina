using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Vacaciones
    {
        public int VacacionesID { get; set; }
        public string meses { get; set; }
        public double sueldo { get; set; }
        public double comisiones { get; set; }
        public double total { get; set; }
        //Relacion con personal 

        public int PersonalId { get; set; }
        public Personal Personal { get; set; }
    }
}
