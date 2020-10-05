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
        //Dado: Un producto con nombre: salchicha, costo 3000, cantidad 0, precio 7000
        //Cuando: Va a ser registrado
        //Entonces: El sistema presentará el mensaje. “Para poder registrar un producto la cantidad debe ser mayor a cero”


        [Test]

        public void CantidadPRoductoARegistrarMayorACeroProductoSimpleTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(nombre: "Salchicha", costo: 3000, precio: 7000 );
            //Acción
            var resultado = productoSimple.RegistrarEntrada(0);
            //Verificación
            Assert.AreEqual("Para poder registrar un producto la cantidad debe ser mayor a cero", resultado);
        }



        /*Escenario 2: Registrar producto y aumentar su cantidad existente
        H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS
        Criterio de Aceptación:  2. La cantidad de la entrada se le aumentará a la cantidad existente del producto
        Dado Un producto con nombre: salchicha, costo 3000, cantidad 3, precio 7000
        Cuando Va a ser registrado
        Entonces    El sistema presentará el mensaje. “Registro exitoso” AND se aumentará la cantidad existente del producto*/

        [Test]

        public void RegistrarYAumentarCantidadExistenteProductoSimpleTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(nombre: "Salchicha", costo: 3000, precio: 7000);
            //Acción
            var registro1 = productoSimple.RegistrarEntrada(5);
            var registro2 = productoSimple.RegistrarEntrada(3);
            //Verificación
            Assert.AreEqual("Registro exitosoo", registro2);
            Assert.AreEqual(productoSimple.Cantidad, 8);
        }





    }
}
