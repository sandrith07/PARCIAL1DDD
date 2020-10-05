using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL1DDD
{
    public class ProductoCompuesto : Producto
    {
        List<ProductoSimple> Ingredientes;
        public ProductoCompuesto(string nombre,  decimal precio, int cantidad, List<ProductoSimple> ingredientes) : base(nombre, precio)
        {
            Ingredientes = ingredientes;
        }

        public override string RegistrarSalida(int cantidad)
        {
            if (cantidad <= 0) return "No se puede vender un producto con cantidad menor o igual a cero";

            
            return "Venta exitosa";

            
        }
    }
}
