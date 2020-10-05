using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL1DDD
{
    public class ProductoCompuesto : Producto
    {
        List<ProductoSimple> Ingredientes;

        public decimal Costo = 0;
        public decimal CostoTotalIngredientes = 0;
        public ProductoCompuesto(string nombre, decimal precio, List<ProductoSimple> ingredientes) : base(nombre, precio)
        {
            Ingredientes = ingredientes;
        }

        public override string RegistrarSalida(int cantidad)
        {
            if (cantidad <= 0) return "No se puede vender un producto con cantidad menor o igual a cero";

            Costo = CalcularCostoIngredientes(Ingredientes);

            return "Venta exitosa";


        }

        public decimal CalcularCostoIngredientes(List<ProductoSimple> ingredientes)
        {

            foreach (ProductoSimple p in ingredientes)
            {
                CostoTotalIngredientes += p.Costo * p.Cantidad;
            }

            return CostoTotalIngredientes;
        }
    }
}

