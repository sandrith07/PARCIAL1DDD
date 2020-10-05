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
             List<ProductoSimple> ingredientes =  new List<ProductoSimple>();

            ingredientes.Add(new ProductoSimple("Pan de perro caliente", 1000, 3000,1));
            ingredientes.Add(new ProductoSimple("Salchicha de perro caliente", 1000, 3000,1));


            var productoCompuesto = new ProductoCompuesto(nombre: "Perro Caliente Sencillo",  precio: 7000, ingredientes);
            //Acción

            var registro2 = productoCompuesto.RegistrarSalida(0);
            //Verificación
            Assert.AreEqual("No se puede vender un producto con cantidad menor o igual a cero", registro2);
            
            

        }
    }
}
