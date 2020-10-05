using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PARCIAL1DDD
{
    public class ProductoSimple : Producto
    {
        
        public ProductoSimple(string nombre, decimal costo, decimal precio, string tipoProducto) : base(nombre, precio)
        {
            
            Costo = costo;
        }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Costo { get; set; }
        public string RegistrarEntrada(int cantidad)
        {         

            if (cantidad <= 0) return "Para poder registrar un producto la cantidad debe ser mayor a cero";

            Cantidad += cantidad;

            return $"Registro exitoso, hay en existencia {Cantidad} productos";

        }

        public override string RegistrarSalida(int cantidad)
        {
            if (cantidad <= 0) return "No se puede vender un producto con cantidad menor o igual a cero";

            PrecioVenta = cantidad * Precio;
            Cantidad -= cantidad;


            return $"El precio de la venta es de ${PrecioVenta}, hay en existencia {Cantidad} productos";
        }
    }
/*
    public class Inventario
    {
        public Inventario(string nombreProducto, decimal costoProducto, decimal precioProducto, int cantidadProducto, string tipoAccion)
        {
            NombreProducto = nombreProducto;
            CostoProducto = costoProducto;
            PrecioProducto = precioProducto;
            CantidadProducto = cantidadProducto;
            TipoAccion = tipoAccion;
        }

        public string NombreProducto { get; set; }
        public decimal CostoProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }
        public string TipoAccion { get; set; }


        public void EntradaProducto() { }

        public int SalidaProducto(int cantidad)
        {
            return 2;
        }
    }*/
}
