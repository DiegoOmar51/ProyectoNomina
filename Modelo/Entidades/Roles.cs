using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Roles
    {
        public int RolesId { get; set; }
        //Relacion con personal 

        public int PersonalId { get; set; }
        public Personal Personal { get; set; }
        public double Arecibir { get; set; }


    }
}
