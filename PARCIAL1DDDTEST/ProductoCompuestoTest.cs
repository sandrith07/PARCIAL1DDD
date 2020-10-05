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
        Dado	Un producto con nombre: Perro Caliente Sencillo, costo (calculado), cantidad 0, precio 7000
        Cuando	Va a ser vendido
        Entonces	El sistema presentará el mensaje. “No se puede vender un producto con cantidad menor o igual a cero” 
         */


        [Test]

        public void CantidadSalidaMayorACeroProductoCompuestoTest()
        {
            //Preparar
            List<ProductoSimple> ingredientes = new List<ProductoSimple>();

            ingredientes.Add(new ProductoSimple("Pan de perro caliente", 1000, 3000, "Ingrediente"));
            ingredientes.Add(new ProductoSimple("Salchicha de perro caliente", 1000, 3000, "Ingrediente"));


            var productoCompuesto = new ProductoCompuesto(nombre: "Perro Caliente Sencillo", precio: 7000, ingredientes);
            //Acción

            var registro2 = productoCompuesto.RegistrarSalida(0);
            //Verificación
            Assert.AreEqual("No se puede vender un producto con cantidad menor o igual a cero", registro2);

        }


        /*
        Escenario 5:  La cantidad saliente del producto se disminuirá de la existente
        H2: COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS
        Criterio de Aceptación:  3. En caso de un producto compuesto la cantidad de la salida se le disminuirá a la cantidad existente de cada uno de sus ingredientes.
        Dado	Un producto con nombre: Perro caliente sencillo, costo (calculado), cantidad 1, precio 7000
        Cuando	Va a ser vendido
        Entonces	El sistema presentará el mensaje. “Venta exitosa” AND restará la cantidad existente de los ingredientes en el inventario.
        */
        /* 

        [Test]

        public void DisminuirCantidadExistenteIngredientesProductoCompuestoTest()
         {

             //Preparar

             ProductoSimple ingrediente1 = new ProductoSimple("Pan de perro caliente", 1000, 3000, 1);
             var registroEntrada1 = ingrediente1.RegistrarEntrada(3);
             ProductoSimple ingrediente2 = new ProductoSimple("Salchicha de perro caliente", 1000, 4000, 1);
             var registroEntrada2 = ingrediente2.RegistrarEntrada(4);

             List<ProductoSimple> ingredientes = new List<ProductoSimple>();

             ingredientes.Add(ingrediente1);
             ingredientes.Add(ingrediente2);


             var productoCompuesto = new ProductoCompuesto(nombre: "Perro Caliente Sencillo", precio: 7000, ingredientes);
             //Acción

             var registro3 = productoCompuesto.RegistrarSalida(1);
             //Verificación
             Assert.AreEqual("Venta exitosa", registro3);
             Assert.AreEqual(ingrediente1.Cantidad, 2);
             Assert.AreEqual(ingrediente2.Cantidad, 3);
         }
         */
    }

}
