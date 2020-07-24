using mallCenter_cs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace mallCenter_cs.Controllers
{
    public class FinanzasController : Controller
    {
        // GET: Finanzas


        [HttpGet]


        public ActionResult Finanzas()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Finanzas(string nom, string cat, int pre, string ofe)
        {
            Productos p = new Productos();

            ViewBag.nombre = ""+nom;
            ViewBag.categoria =""+ cat;
            ViewBag.precio = "Precio Normal: "+pre;
            ViewBag.oferta = ""+ofe;

            ViewBag.mostrarCategoria = "" + p.mostrarCategoria(cat);
            ViewBag.calcularPromocion = "" + p.calcularPromocion(pre, ofe);
            return View(); 
        }

    }
}