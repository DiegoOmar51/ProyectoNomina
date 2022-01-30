using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Personal
    {
        public int PersonalId { get; set; }
        public String nombre { get; set; }
        public String telefono { get; set; }
        public String no_documento { get; set; }
        public double sueldo { get; set; }
        public String estado_civil { get; set; }

        //Relacion con Decimo Cuarto
        public List<Decimo_Cuarto> Decimos_Cuartos { get; set; }

        //Relacion con Decimo Tercero
        public List<Decimo_Tercero> Decimos_Terceros { get; set; }

        //Relacion con Vacaciones
        public List<Vacaciones> Vacaciones { get; set; }

        //Relacion con Fondos de reserva
        public List<Fondo_reserva> Fondo_reserva { get; set; }

        //Relacion con Roles
        public List<Roles> Roles { get; set; }

        //Relacion con Departamento 
        public Departamento Departamento { get; set; }
        
    }
}
