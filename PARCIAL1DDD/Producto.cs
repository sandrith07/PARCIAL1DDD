using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL1DDD
{
    public abstract class  Producto
    {

        protected Producto(string nombre, decimal costo, decimal precio)
        {
            Nombre = nombre;
            Costo = costo;
            Precio = precio;
        }

        public string Nombre { get; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }

      

            
    }
}
