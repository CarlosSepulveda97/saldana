using mallCenter_cs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mallCenter_cs.Services
{
    public class ProductosServices
    {

        public List<Productos> obtenerProductos()
        {
            return new List<Productos>
            {
                new Productos
                {
                    id=1,
                    nombre="Zapatillas",
                    categoria="Vestuario",
                    precio=50000,
                    oferta="No oferta"
                },
                new Productos
                {
                    id=2,
                    nombre="Pantalon",
                    categoria="Vestuario",
                    precio=25000,
                    oferta="No oferta"
                },
                new Productos
                {
                    id=3,
                    nombre="Notebook",
                    categoria="Electronica",
                    precio=500000,
                    oferta="En oferta"
                },
                new Productos
                {
                    id=4,
                    nombre="Ventilador",
                    categoria="Electrodomesticos",
                    precio=50000,
                    oferta="No oferta"
                },
                new Productos
                {
                    id=5,
                    nombre="Sarten",
                    categoria="Cocina",
                    precio=20000,
                    oferta="No oferta"
                },
            };
        }


    }
}