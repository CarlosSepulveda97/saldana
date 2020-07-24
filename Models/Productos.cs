using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mallCenter_cs.Models
{
    public class Productos
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public int precio { get; set; }
        public string oferta { get; set; }

        public string mostrarCategoria(string categoria)
        {
            if (categoria.Equals("Vestimenta") || categoria.Equals("Electrodomesticos") || categoria.Equals("Electronica"))
            {
                return "Ha seleccionado: " + categoria;
            }
            else
            {
                return "Debes seleccionar una categoria.";
            }
        }


        public int calcularPromocion(int precio, string oferta)
        {
            if (oferta.Equals("En Oferta"))
            {
                return precio/2;
            }
            else if (oferta.Equals("No Oferta"))
            {
                return precio;
            }

            return 0;
        }
    }
}