using System;
using System.Collections.Generic;
using CargaDatos;
using Modelo.Entidades;
using ModeloDB;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CargaDatos.DatosIniciales;

namespace Consola
{
    public class Grabar
    {
        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            // Extraer del diccionario las listas
            var listaPersonal = (List<Personal>)listas[ListasTipo.Personal];
           

            using (NominaDB db = NominaDBBuilder.Crear())
            {
                // Se asegura que se borre y vuelva a crear la base de datos
                /*db.PreparaDB();
                // Agrega los listados
                db.carreras.AddRange(listaCarreras);
                db.periodos.AddRange(listaPeriodos);
                db.materias.AddRange(listaMaterias);
                db.configuracion.AddRange(listaConfiguracion);
                db.mallas.AddRange(listaSubMallas);
                db.mallas.AddRange(listaMallas);
                db.niveles.AddRange(listaNiveles);
                db.cursos.AddRange(listaCursos);
                // Guarda todos los datos
                db.SaveChanges();*/
            }
        }
    }
}
