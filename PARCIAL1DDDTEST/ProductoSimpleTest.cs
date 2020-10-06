using NUnit.Framework;
using PARCIAL1DDD;
using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL1DDDTEST
{
    class ProductoSimpleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        //Escenario 1: Cantidad Producto Mayor a 0
        //H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS
        //Criterio de Aceptación:  La cantidad de la entrada de debe ser mayor a 0
        //Dado: Un producto con nombre: salchicha, costo 3000,  precio 7000 y de tipo Ingrediente
        //Cuando: se va a registrar cantidad 0
        //Entonces: El sistema presentará el mensaje. “Para poder registrar la entrada de un producto la cantidad debe ser mayor a cero”


        [Test]

        public void CantidadProductoARegistrarMayorACeroProductoSimpleTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(nombre: "Salchicha", costo: 3000, precio: 7000, tipoProducto: "Ingrediente");
            //Acción
            var resultado = productoSimple.RegistrarEntrada(0);
            //Verificación
            Assert.AreEqual("Para poder registrar un producto la cantidad debe ser mayor a cero", resultado);
        }



        /*Escenario 2: Registrar producto con una cantidad inicial de 3
        H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS
        Criterio de Aceptación:  2. La cantidad de la entrada se le aumentará a la cantidad existente del producto
        Dado Un producto con nombre: salchicha, costo 3000, precio 7000 y de tipo Ingrediente
        Cuando Va a ser registrado con una cantidad inicial de 3
        Entonces    El sistema presentará el mensaje. “Registro exitoso, hay en existencia 3 productos” AND se aumentará la cantidad existente del producto*/

        [Test]

        public void RegistroInicialProductoSimpleTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(nombre: "Salchicha", costo: 3000, precio: 7000, tipoProducto: "Ingrediente");
            //Acción
            var registro = productoSimple.RegistrarEntrada(3);
            //Verificación
            Assert.AreEqual("Registro exitoso, hay en existencia 3 productos", registro);
     
        }



        /*Escenario 3: Registrar producto y aumentar su cantidad existente
        H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS
        Criterio de Aceptación:  2. La cantidad de la entrada se le aumentará a la cantidad existente del producto
        Dado Un producto con nombre: salchicha, costo 3000, precio 7000 y de tipo Ingrediente, con una cantidad existente de 5
        Cuando Va se va a registrar una entrada de el de 3
        Entonces    El sistema presentará el mensaje. “Registro exitoso, hay en existencia 8 productos” */

        [Test]

        public void RegistrarYAumentarCantidadExistenteProductoSimpleTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(nombre: "Salchicha", costo: 3000, precio: 7000, tipoProducto: "Ingrediente");
            var registro1 = productoSimple.RegistrarEntrada(5);
            //Acción
            var registro2 = productoSimple.RegistrarEntrada(3);
            //Verificación
            Assert.AreEqual("Registro exitoso, hay en existencia 8 productos", registro2);

        }



        /*
        Escenario 3: Salida del producto mayor a 0
        H2: COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS
        Criterio de Aceptación:  1. La cantidad de la salida de debe ser mayor a 0
        Dado	Un producto con nombre: Gaseosa, costo 4000, precio 7000, típo de producto de venta directa y con una existencia en el inventario de 5
        Cuando	Va a ser vendido (cuando se va a registrar una salida)
        Entonces	El sistema presentará el mensaje. “No se puede vender un producto con cantidad menor o igual a cero” 
         */


        [Test]

        public void CantidadSalidaMayorACeroProductoSimpleTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(nombre: "Gaseosa", costo: 4000, precio: 7000, tipoProducto: "Venta Directa");
            var registroEntrada = productoSimple.RegistrarEntrada(5);
            //Acción
            var registroSalida = productoSimple.RegistrarSalida(0);
            //Verificación
            Assert.AreEqual("No se puede vender un producto con cantidad menor o igual a cero", registroSalida);

        }


        /*
        Escenario 4: Salida del producto mayor a la cantidad de existencia
        H2: COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS
        Criterio de Aceptación:  1. La cantidad de la salida de debe ser mayor a 0
        Dado	Un producto con nombre: Gaseosa, costo 4000, precio 7000, típo de producto de venta directa y con una existencia en el inventario de 5
        Cuando	Va a va a vender 10 unidades del mismo(cuando se va a registrar una salida)
        Entonces	El sistema presentará el mensaje. "No hay suficientes productos para hacer la venta"
         */
        

        [Test]

        public void CantidadSalidaMayorALaExistenciaProductoSimpleTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(nombre: "Gaseosa", costo: 4000, precio: 7000, tipoProducto: "Venta Directa");
            var registroEntrada = productoSimple.RegistrarEntrada(5);
            //Acción
            var registroSalida = productoSimple.RegistrarSalida(7);
            //Verificación
            Assert.AreEqual("No hay suficientes productos para hacer la venta", registroSalida);

        }

        /*
        Escenario 5:  La cantidad saliente del producto se disminuirá de la existente
        H2: COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS
        Criterio de Aceptación:  2. En caso de un producto sencillo la cantidad de la salida se le disminuirá a la cantidad existente del producto.
        Dado	Un producto con nombre: Gaseosa, costo 4000, precio 7000, tipo de producto "Venta Directa" y con una existencia en el inventario de 5
        Cuando	Va a ser vendido
        Entonces	El sistema presentará el mensaje. “El precio de la venta es de $14000, hay en existencia 3 productos” AND restará la cantidad existente del producto en el inventario. 
 
        */


        [Test]

        public void DisminuirCantidadExistenteProductoSimpleTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(nombre: "Gaseosa", costo: 4000, precio: 7000, tipoProducto: "Venta Directa");
            var registro1 = productoSimple.RegistrarEntrada(5);
            //Acción
            var salida = productoSimple.RegistrarSalida(2);
            //Verificación
            Assert.AreEqual("El precio de la venta es de $14000, hay en existencia 3 productos", salida);
           

        }


        /*
       Escenario 6:  el producto saliente no es para venta directa
       H2: COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS
       Criterio de Aceptación:  2. En caso de un producto sencillo la cantidad de la salida se le disminuirá a la cantidad existente del producto.
       Dado	Un producto con nombre: Salchicha, costo 4000, precio 7000, tipo de producto "Ingrediente" y con una existencia en el inventario de 5
       Cuando	Va a ser vendido
       Entonces	El sistema presentará el mensaje. “El producto no es para la venta directa”. 

       */


        [Test]

        public void NoProductoVentaDirectaProductoSimpleTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(nombre: "Salchicha", costo: 4000, precio: 7000, tipoProducto: "Ingrediente");
            var registro1 = productoSimple.RegistrarEntrada(5);
            //Acción
            var salida = productoSimple.RegistrarSalida(2);
            //Verificación
            Assert.AreEqual("El producto no es para la venta directa", salida);


        }



    }
}
