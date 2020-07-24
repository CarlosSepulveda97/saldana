using mallCenter_cs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mallCenter_cs.Controllers
{
    public class ProductosController : Controller
    {
        private ProductosServices productosServices;

        public ProductosController()
        {
            productosServices = new ProductosServices();
            
        }

        // GET: Productos
        public ActionResult Listado()
        {
            var model = productosServices.obtenerProductos();
            return View(model);
        }
    }
}