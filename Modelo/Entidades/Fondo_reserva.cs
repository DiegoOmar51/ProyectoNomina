using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Fondo_reserva
    {
        public int Fondo_reservaId { get; set; }
        //Relacion con personal 
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }
        public int porcentaje { get; set; }
        public double valor { get; set; }
        
    }
}
