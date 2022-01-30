using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        //Relacion uno a uno con Personal
        public int? PersonalId { get; set; }
        public Personal Personal { get; set; }
        public string departamento { get; set; }
    }
}
