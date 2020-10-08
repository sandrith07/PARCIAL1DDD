using NUnit.Framework;
using PARCIAL1DDD;
using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL1DDDTEST
{
    class ProductoCompuestoTest
    {

        /*
        Escenario 3: Salida del producto mayor a 0
        H2: COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS
        Criterio de Aceptación:  1. La cantidad de la salida de debe ser mayor a 0
        Dado	Dos producto con nombre: Perro Caliente Sencillo, costo (calculado), precio 7000
        Cuando	Van a ser vendidos
        Entonces	El sistema presentará el mensaje. “No se puede vender un producto con cantidad menor o igual a cero” 
         */


        [Test]

        public void CantidadSalidaMayorACeroProductoCompuestoTest()
        {

            //Preparar

            ProductoSimple ingrediente1 = new ProductoSimple("Pan de perro caliente", 2500, 3000, "Ingrediente");
            var registroEntradaI1 = ingrediente1.RegistrarEntrada(10);

            ProductoSimple ingrediente2 = new ProductoSimple("Salchicha de perro caliente", 1000, 4000, "Ingrediente");
            var registroEntradaI2 = ingrediente2.RegistrarEntrada(10);

            ProductoSimple ingrediente3 = new ProductoSimple("Lamina de queso", 1000, 4000, "Ingrediente");
            var registroEntradaI3 = ingrediente3.RegistrarEntrada(10);

            List<ProductoSimple> ingredientes = new List<ProductoSimple>();

            ingredientes.Add(ingrediente1);
            ingredientes.Add(ingrediente2);
            ingredientes.Add(ingrediente3);


            var productoCompuesto = new ProductoCompuesto(nombre: "Perro Caliente Sencillo", precio: 7000);
            productoCompuesto.AñadirIngredientes(ingrediente1, 1);
            productoCompuesto.AñadirIngredientes(ingrediente2, 1);
            productoCompuesto.AñadirIngredientes(ingrediente3, 1);
            //Acción
            var registroSalida = productoCompuesto.SalidaProducto(0);

            //Verificación
           
            Assert.AreEqual("No se puede vender un producto con cantidad menor o igual a cero", registroSalida);




        }


        /*
        Escenario 5:  La cantidad saliente del producto se disminuirá de la existente
        H2: COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS
        Criterio de Aceptación:  3. En caso de un producto compuesto la cantidad de la salida se le disminuirá a la cantidad existente de cada uno de sus ingredientes.
        Dado	dos producto con nombre: Perro caliente sencillo, costo (calculado), precio 7000
        Cuando	Van a ser vendidos
        Entonces	El sistema presentará el mensaje. “El precio de la venta es de $14000” AND restará la cantidad existente de los ingredientes en el inventario.
        */


        [Test]

        public void DisminuirCantidadExistenteIngredientesProductoCompuestoTest()
         {

             //Preparar

             ProductoSimple ingrediente1 = new ProductoSimple("Pan de perro caliente", 2500, 3000, "Ingrediente");
            var registroEntradaI1 = ingrediente1.RegistrarEntrada(10);
            
             ProductoSimple ingrediente2 = new ProductoSimple("Salchicha de perro caliente", 1000, 4000, "Ingrediente");
            var registroEntradaI2 = ingrediente2.RegistrarEntrada(10);

            ProductoSimple ingrediente3 = new ProductoSimple("Lamina de queso", 1000, 4000, "Ingrediente");
            var registroEntradaI3 = ingrediente3.RegistrarEntrada(10);

            List<ProductoSimple> ingredientes = new List<ProductoSimple>();

             ingredientes.Add(ingrediente1);
             ingredientes.Add(ingrediente2);
             ingredientes.Add(ingrediente3);


            var productoCompuesto = new ProductoCompuesto(nombre: "Perro Caliente Sencillo", precio: 7000);
            productoCompuesto.AñadirIngredientes(ingrediente1, 1);
            productoCompuesto.AñadirIngredientes(ingrediente2, 1);
            productoCompuesto.AñadirIngredientes(ingrediente3, 1);

            //Acción
            var registroSalida = productoCompuesto.SalidaProducto(1);

            //Verificación
            Assert.AreEqual(ingrediente1.Cantidad, 9);
            Assert.AreEqual(ingrediente2.Cantidad, 9);
            Assert.AreEqual(ingrediente3.Cantidad, 9);
            
           
         }
        
    }

}
