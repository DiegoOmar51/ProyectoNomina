using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class PersonalController : Controller
    {
        //Listas el personal
        private readonly NominaDB db;
        public PersonalController(NominaDB db)
        {
            this.db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Personal> listaPersonales = db.Personales;
            return View(listaPersonales);
        }

        //Metodo de crear personal
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Personal personal)
        {
            //Grabar la materia
            db.Personales.Add(personal);
            db.SaveChanges();

            TempData["mensaje"] = $"Personal {personal.nombre} ha sido ingresado correctamente";
            return RedirectToAction("Index");

        }

        //Edicion de materia
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Consultar el id de la materia
            Personal personal = db.Personales.Find(id);
            return View(personal);
        }
        [HttpPost]
        public IActionResult Edit(Personal personal)
        {
            //Grabar la materia
            db.Personales.Update(personal);
            db.SaveChanges();

            TempData["mensaje"] = $"Personal {personal.nombre} con el codigo {personal.PersonalId} ha sido actualizada correctamente";
            return RedirectToAction("Index");

        }
        //Elimina de materia
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Consultar el id de la materia
            Personal personal = db.Personales.Find(id);
            return View(personal);
        }
        [HttpPost]
        public IActionResult Delete(Personal personal)
        {
            //Grabar la materia
            db.Personales.Remove(personal);
            db.SaveChanges();

            TempData["mensaje"] = $"Personal {personal.nombre} con el codigo {personal.PersonalId} ha sido eliminada correctamente";
            return RedirectToAction("Index");

        }
        
        
    }
}
