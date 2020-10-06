using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComidasRapidas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComidasRapidas.Tests
{
    [TestClass()]
    public class InvetarioTests
    {

        //Escenario: Cantidad del producto negativo o cero 
        //H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS  
        //Criterio de Aceptación:
        //1.1 La cantidad de la entrada de debe ser mayor a 0
        //Ejemplo
        //Dado Un producto cuya cantidad de acceso a inventario es menor o igual a 0                                      //A =>Arrange /Preparación
        // id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 0                              
        //Cuando Va a agregar un producto con una cantidad menor o igual a cero  (0)                            //A =>Act = Acción
        //Entonces El sistema presentará el mensaje. "La cantidad de prodcuto no es validad, verifique.o”  //A => Assert => Validación
        [TestMethod()]
        public void AgregarProductoMenorIgualCeroTest()
        {
            //Preparar
            ProductoSimple producto = new ProductoSimple(id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 0);
            //Acción
            var inventario = new Inventario().AgregarProductosNuevos(producto);
            //Verificación
            Assert.AreEqual("La cantidad de prodcuto no es validad, verifique.", inventario);
        }

        //Escenario: Cantidad del producto negativo o cero 
        //H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS  
        //Criterio de Aceptación:
        //1.2 La cantidad de la entrada se le aumentará a la cantidad existente del producto
        //Ejemplo
        //Dado Un producto cuya cantidad es mayor a 0 se debe agregar al inventario        //A =>Arrange /Preparación
        // id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 3                              
        //Cuando Va a agregar un producto con cantidad menor o igual a cero  (0)                            //A =>Act = Acción
        //Entonces El sistema presentará el mensaje. "El producto pan de perro con el precio de: $0.00 y la cantidad de: 3"  //A => Assert => Validación
        [TestMethod()]
        public void AgregarProductosNuevosTest()
        {
            //Preparar
            ProductoSimple producto = new ProductoSimple(id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 3);
            //Acción
            var inventario = new Inventario().AgregarProductosNuevos(producto);
            //Verificación
            Assert.AreEqual("El producto pan de perro con el precio de: $0.00 y la cantidad de: 3", inventario);
        }

        //Escenario: Cantidad del producto negativo o cero 
        //H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS  
        //Criterio de Aceptación:
        //1.2 La cantidad de la entrada se le aumentará a la cantidad existente del producto
        //Ejemplo
        //Dado Un producto cuya cantidad es mayor a 0 se debe agregar al inventario        //A =>Arrange /Preparación
        // id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 3                             
        //Cuando Va a agregar cantidad de producto a uno ya registrado se le suma al inventario actual                          //A =>Act = Acción
        //Entonces El sistema presentará el mensaje. "Se actualizo el producto: pan de perro cantidad anterior: 3, Cantidad actual: 23" //A => Assert => Validación
        [TestMethod()]
        public void AgregarCantidadProductosActualesTest()
        {
            //Preparar
            Inventario alamacen = new Inventario();
            ProductoSimple producto = new ProductoSimple(id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 3);
            //Acción
            alamacen.AgregarProductosNuevos(producto);
            var inventario = alamacen.AgregarProductos("2",20);
            //Verificación
            Assert.AreEqual("Se actualizo el producto: pan de perro cantidad anterior: 3, Cantidad actual: 23", inventario);
        }

        //Escenario: Cantidad del producto negativo o cero 
        //H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS  
        //Criterio de Aceptación:
        //1.2 La cantidad de la entrada se le aumentará a la cantidad existente del producto
        //Ejemplo
        //Dado Un producto cuya cantidad es mayor a 0 se debe agregar al inventario        //A =>Arrange /Preparación
        // id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 3                             
        //Cuando Va a agregar cantidad de producto a uno que no ha sido registrado se le suma al inventario actual                          //A =>Act = Acción
        //Entonces El sistema presentará el mensaje. "Se actualizo el producto: pan de perro cantidad anterior: 3, Cantidad actual: 23" //A => Assert => Validación
        [TestMethod()]
        public void AgregarCantidadProductosActualeFallaTest()
        {
            //Preparar
            Inventario alamacen = new Inventario();
            ProductoSimple producto = new ProductoSimple(id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 3);
            //Acción
            alamacen.AgregarProductosNuevos(producto);
            var inventario = alamacen.AgregarProductos("1", 20);
            //Verificación
            Assert.AreEqual("El producto solicitado no existe", inventario);
        }

    }
}