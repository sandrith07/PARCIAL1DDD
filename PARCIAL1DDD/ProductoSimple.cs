using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL1DDD
{
    public class ProductoSimple : Producto
    {
        public int Cantidad = 0;
        public ProductoSimple(string nombre, decimal costo, decimal precio) : base(nombre, costo, precio)
        {
        }
        public string RegistrarEntrada(int cantidad)
        {
          

            if (cantidad <= 0) return "Para poder registrar un producto la cantidad debe ser mayor a cero";

            Cantidad += cantidad;

            return "Registro exitoso";
        }
    }
}
