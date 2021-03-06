﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PARCIAL1DDD
{
    public class ProductoCompuesto : Producto
    {
        List<ProductoSimple> ingredientes = new List<ProductoSimple>();
        ProductoSimple IngredienteRequerido;
        public int cantidadRequeridaIngredienteTotal = 0;

        public decimal Costo { get; set; }
        public decimal CostoTotalIngredientes = 0;
        public int CantidadRequeridaProducto { get; set; }
    
        public ProductoCompuesto(string nombre, decimal precio) : base(nombre, precio)
        {
            
            
        }

       // public override string RegistrarSalida(int cantidadRequeridaProducto)
       // {
        /*    CantidadRequeridaProducto = cantidadRequeridaProducto;
            if (cantidadRequeridaProducto <= 0) return "No se puede vender un producto con cantidad menor o igual a cero";

            
            /*DisminuirCantidadIngredientesExistentes(Ingredientes);*/


         /*   PrecioVenta = CantidadRequeridaProducto * Precio;
   

            return $"El precio de la venta es de ${PrecioVenta}";

        }*/

        public string SalidaProducto(int cantidadRequeridaProducto)
        {

            CantidadRequeridaProducto = cantidadRequeridaProducto;
            if (cantidadRequeridaProducto <= 0) return "No se puede vender un producto con cantidad menor o igual a cero";

            PrecioVenta = CantidadRequeridaProducto * Precio;

            var aux = cantidadRequeridaIngredienteTotal * cantidadRequeridaProducto;            
            
            if (cantidadRequeridaProducto > 1)
            {
                IngredienteRequerido.RegistrarSalida(aux);
            }
            

            return $"El precio de la venta es de ${PrecioVenta}";
        }

        public void AñadirIngredientes(ProductoSimple ingredienteRequerido, int cantidadRequeridaIngrediente) {



            IngredienteRequerido = ingredienteRequerido;
            cantidadRequeridaIngredienteTotal = cantidadRequeridaIngrediente;
            IngredienteRequerido.RegistrarSalida(cantidadRequeridaIngredienteTotal);
            //  ingredienteRequerido.RegistrarSalida(cantidadRequeridaIngredienteTotal);

            ingredientes.Add(ingredienteRequerido);
        }

     

        /**/

        public void CalcularCostoIngredientes(ProductoSimple ingrediente, int cantidadRequeridaIngrediente)
        {
          

            var CostoIngredienteTotal = ingrediente.Costo * cantidadRequeridaIngrediente * CantidadRequeridaProducto;
            Costo += CostoIngredienteTotal;
            
           
        }
        
        /*
         
        public void DisminuirCantidadIngredientesExistentes(List<ProductoSimple> ingredientes)
        {
            int count = ingredientes.Count();
            foreach (ProductoSimple p in ingredientes)
            {
                for ( int i=1; i<=count; i++)
                {
                    p.RegistrarSalida(1);
                }
            }

            
            
        }*/

    }
}

