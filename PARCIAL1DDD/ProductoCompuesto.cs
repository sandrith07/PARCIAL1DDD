using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            /*DisminuirCantidadIngredientesExistentes(Ingredientes);*/

           CostoTotalIngredientes = CalcularCostoIngredientes(Ingredientes);
           Costo = CostoTotalIngredientes * cantidad;
           


            return "Venta exitosa";


        }

        public decimal CalcularCostoIngredientes(List<ProductoSimple> ingredientes)
        {
            decimal costoTotal=0;
            foreach (ProductoSimple p in ingredientes)
            {
                costoTotal += p.Costo * p.Cantidad;
            }

            return costoTotal;
           
        }
        /*
         
        public void DisminuirCantidadIngredientesExistentes(List<ProductoSimple> ingredientes)
        {
            int count = ingredientes.Count();
            foreach (ProductoSimple p in ingredientes)
            {
                for ( int i=1; i<=count; i++)
                {
                    p.RegistrarSalida(p.Cantidad);
                }
            }

            
            
        }*/

    }
}

