using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL1DDD
{
    public class Ingrediente: ProductoSimple
    {
        public Ingrediente(string nombre, decimal costo, decimal precio, string tipoProducto) : base (nombre,costo,precio,tipoProducto)
        {

        }
    }
}
