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
        //Cuando Va a consignar un valor menor o igual a cero  (0)                            //A =>Act = Acción
        //Entonces El sistema presentará el mensaje. “El valor a consignar es incorrecto”  //A => Assert => Validación
        [TestMethod()]
        public void AgregarProductoMenorIgualCeroTest()
        {
            //Preparar
            ProductoSimple producto = new ProductoSimple(id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 0);
            //Acción
            var inventario = new Invetario().AgregarProductos(producto);
            //Verificación
            Assert.AreEqual("La cantidad de prodcuto no es validad, verifique.", inventario);
        }

        //Escenario: Cantidad del producto negativo o cero 
        //H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS  
        //Criterio de Aceptación:
        //1.2 La cantidad de la entrada se le aumentará a la cantidad existente del producto
        //Ejemplo
        //Dado Un producto cuya cantidad es mayor a 0 se debe agregar al inventario        //A =>Arrange /Preparación
        // id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 0                              
        //Cuando Va a consignar un valor menor o igual a cero  (0)                            //A =>Act = Acción
        //Entonces El sistema presentará el mensaje. “El valor a consignar es incorrecto”  //A => Assert => Validación
        [TestMethod()]
        public void AgregarProductosATest()
        {
            //Preparar
            ProductoSimple producto = new ProductoSimple(id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 3);
            //Acción
            var inventario = new Invetario().AgregarProductos(producto);
            //Verificación
            Assert.AreEqual("El producto pan de perro con el precio de: $0.00 y la cantidad de: 1", inventario);
        }

        [TestMethod()]
        public void QuitarProductosTest()
        {
            Assert.Fail();
        }
    }
}