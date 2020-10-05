using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL1DDD
{
    public abstract class  Producto
    {
      
        public int costo = 0;
        protected Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
           
        }

        public string Nombre { get; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }

        

        public virtual string RegistrarSalida(int cantidad)
      {
            if (cantidad <= 0) return "No se puede vender un producto con cantidad menor o igual a cero";
            return "";

      }

            
    }
}
