using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Grabar grabar = new Grabar();
            grabar.DatosIni();

            using (var db = NominaDBBuilder.Crear())
            {
                /*var lista = db.Personales.lista
                    .Include(curso => curso.Carrera)
                    .Include(curso => curso.Materia)
                    .Include(curso => curso.Periodo)
                    ;

                Console.WriteLine("Listado de cursos");
                foreach (var curso in listaCursos)
                {
                    Console.WriteLine(
                        curso.Carrera.Nombre + " " +
                        curso.Materia.Nombre + "\t\t\t" +
                        curso.Periodo.Nombre + "\t" +
                        curso.Nombre
                    );
                }*/
            }
        }
    }
}
