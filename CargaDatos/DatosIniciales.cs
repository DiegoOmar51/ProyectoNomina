using Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo
        {
            Personal, Decimo_Cuarto, Decimo_Tercero,
            Fondo_reserva, Roles, Vacaciones,
            Departamento
        }
        public Dictionary<ListasTipo, object> Carga()
        {

            //Lista de Personales
            #region
            Personal personal1 = new Personal()            
            {
                nombre = "Diego Patino",
                telefono = "0984231388",
                no_documento = "1722644299",
                sueldo = 400.5,
                estado_civil = "Soltero"

            };

            Personal personal2 = new Personal()
            {
                nombre = "Diana Loachamin",
                telefono = "0984231388",
                no_documento = "1722644299",
                sueldo = 600.5,
                estado_civil = "Soltero"

            };

            Personal personal3 = new Personal()
            {
                nombre = "Bryan Arevalo",
                telefono = "0984231388",
                no_documento = "1722644299",
                sueldo = 700.5,
                estado_civil = "Casado"

            };
            List<Personal> listaPersonal = new List<Personal>()
            {
                personal1, personal2, personal3
            };
            #endregion
            //Fin Lista de Personales
            //Lista de Decimos Terceros
            #region
            Decimo_Tercero dec1 = new Decimo_Tercero
            {                
                Personal = personal1,
                finicio = new DateTime(2020, 3, 1),
                ffinal = new DateTime(2020, 3, 1),
                meses ="12",
                total = 500.6
            };
            Decimo_Tercero dec2 = new Decimo_Tercero
            {
                Personal = personal2,
                finicio = new DateTime(2020, 3, 1),
                ffinal = new DateTime(2020, 3, 1),
                meses = "12",
                total = 500.6
            };
            Decimo_Tercero dec3 = new Decimo_Tercero
            {
                Personal = personal3,
                finicio = new DateTime(2020, 3, 1),
                ffinal = new DateTime(2020, 3, 1),
                meses = "12",
                total = 500.6
            };
            List<Decimo_Tercero> listaD13 = new List<Decimo_Tercero>()
            {
                dec1, dec2, dec3
            };
            #endregion
            //Fin Lista de Decimos Terceros
            //Lista de Decimos Cuartos
            #region
            Decimo_Cuarto decc1 = new Decimo_Cuarto
            {
                Personal = personal1,
                meses = "12",
                total = 500.6
            };
            Decimo_Cuarto decc2 = new Decimo_Cuarto
            {
                Personal = personal2,
                meses = "12",
                total = 500.6
            };
            Decimo_Cuarto decc3 = new Decimo_Cuarto
            {
                Personal = personal3,
                meses = "12",
                total = 500.6
            };
            List<Decimo_Cuarto> listaD14 = new List<Decimo_Cuarto>()
            {
                decc1, decc2, decc3
            };
            #endregion
            //Fin Lista de decimos Cuartos
            //Lista de Fondos de Reserva
            #region
            Fondo_reserva fd1 = new Fondo_reserva
            {
                Personal = personal1,
                porcentaje = 10,
                valor = 33.33
            };
            Fondo_reserva fd2 = new Fondo_reserva
            {
                Personal = personal2,
                porcentaje = 10,
                valor = 33.33
            };
            Fondo_reserva fd3 = new Fondo_reserva
            {
                Personal = personal3,
                porcentaje = 10,
                valor = 33.33
            };
            List<Fondo_reserva> listafr = new List<Fondo_reserva>()
            {
                fd1, fd2, fd3
            };
            #endregion
            //Fin Lista fondos de reserva
            //Lista de Vacaciones
            #region
            Vacaciones vac1 = new Vacaciones
            {
                Personal = personal1,
                meses = "12",
                sueldo = 500.1,
                comisiones = 50.1,
                total = 100
            };
            Vacaciones vac2 = new Vacaciones
            {
                Personal = personal2,
                meses = "12",
                sueldo = 500.1,
                comisiones = 50.1,
                total = 100
            };
            Vacaciones vac3 = new Vacaciones
            {
                Personal = personal3,
                meses = "12",
                sueldo = 500.1,
                comisiones = 50.1,
                total = 100
            };

            List<Vacaciones> listavac = new List<Vacaciones>
            {
                vac1,vac2,vac3
            };
            #endregion
            //Fin Lista de Vacaciones
            // --------------------------------------------
            // Diccionario contiene todas las listas
            // --------------------------------------------
            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Personal, listaPersonal},
                { ListasTipo.Decimo_Tercero, listaD13},
                { ListasTipo.Decimo_Cuarto, listaD14},
                { ListasTipo.Fondo_reserva, listafr },
                { ListasTipo.Vacaciones, listavac }
            };

            return dicListasDatos;
        }
    }
}
