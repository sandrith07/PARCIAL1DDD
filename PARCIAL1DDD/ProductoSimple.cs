using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PARCIAL1DDD
{
    public class ProductoSimple : Producto
    {
        
        public ProductoSimple(string nombre, decimal costo, decimal precio, string tipoProducto) : base(nombre, precio)
        {
            TipoProducto = tipoProducto;
            Costo = costo;
            _inventario = new List<Inventario>();
        }
        public int Cantidad { get; set; }
        
        public string TipoProducto { get; set; }
        public decimal Costo { get; set; }
        public string RegistrarEntrada(int cantidad)
        {         

            if (cantidad <= 0) return "Para poder registrar un producto la cantidad debe ser mayor a cero";

           

            Cantidad += cantidad;

            _inventario.Add(new Inventario(Cantidad, Nombre, Costo, Precio, TipoProducto));

            return $"Registro exitoso, hay en existencia {Cantidad} productos";

        }

        public override string RegistrarSalida(int cantidad)
        {
            if (cantidad <= 0) return "No se puede vender un producto con cantidad menor o igual a cero";
            
            if (cantidad > StockProducto()) return "No hay suficientes productos para hacer la venta";

            PrecioVenta = cantidad * Precio;
            Cantidad -= cantidad;

            _inventario.Add(new Inventario(Cantidad, Nombre, Costo, Precio, TipoProducto));
            return $"El precio de la venta es de ${PrecioVenta}, hay en existencia {Cantidad} productos";
        }

        public int StockProducto()
        {
            var stock = from producto in _inventario
                            where producto.NombreProducto == Nombre
                            orderby producto.CantidadExistente
                            select producto.CantidadExistente;
            
            return stock.First();
        }
       
        public readonly List<Inventario> _inventario;

    }

}
