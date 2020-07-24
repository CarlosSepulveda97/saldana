using mallCenter_cs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mallCenter_cs.Controllers
{
    public class ProfesionalesController : Controller
    {
        // GET: Profesionales
        public JsonResult Profesionales()
        {
            var profesional = new Profesionales()
            {
                Nombre = "Carlos",
                Edad = 23,
                Cargo = "Dev",
                Salario = 1500,
            };

            var profesional2 = new Profesionales()
            {
                Nombre = "Camila",
                Edad = 25,
                Cargo = "Profesora",
                Salario = 2000,
            };

            //return Json(profesional, JsonRequestBehavior.AllowGet);

            return Json(new List<Profesionales>() {profesional, profesional2}, JsonRequestBehavior.AllowGet);

        }
    }
}