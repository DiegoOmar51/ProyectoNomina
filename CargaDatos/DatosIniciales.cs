using System;
using System.Collections.Generic;
using Modelo.Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo
        {
            Personal, Decimo_Cuarto, Decimo_Tercero,
            Fondo_reserva, Vacaciones, Roles, 
            Departamento
        }
        public Dictionary<ListasTipo, object> Carga()
        {

        }

    }
}
