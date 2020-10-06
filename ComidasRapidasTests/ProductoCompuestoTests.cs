using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComidasRapidas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComidasRapidas.Tests
{
    [TestClass()]
    public class ProductoCompuestoTests
    {
        //Escenario: Cantidad del producto cero o mayor 
        //H2: COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS   
        //Criterio de Aceptación:
        //1.1 La cantidad de la salida de debe ser mayor a 0
        //Ejemplo
        //Dado Un producto cuya cantidad de acceso a inventario es menor o igual a 0                                      //A =>Arrange /Preparación
        // id: "2", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 0                              
        //Cuando Va a sacar un producto compuesto con una cantidad Mayor o igual a cero  (0)                            //A =>Act = Acción
        //Entonces El sistema presentará el mensaje. "No se puede crear la receta, faltan ingredientes”  //A => Assert => Validación
        [TestMethod()]
        public void SacarProductoMenorIgualCeroTest()
        {
            //Preparar
            ProductoSimple panPerro = new ProductoSimple(id: "1", nombre: "pan de perro", precio: 0, costo: 1000, cantidad: 1);
            ProductoSimple salchicha = new ProductoSimple(id: "2", nombre: "salchicha", precio: 0, costo: 1000, cantidad: 1);
            ProductoSimple queso = new ProductoSimple(id: "3", nombre: "queso", precio: 0, costo: 1000, cantidad: 1);
            ProductoCompuesto receta = new ProductoCompuesto("1", "perro caliente sencillo", 5000, panPerro.Costo+salchicha.Costo+queso.Costo);
            var inventario = new Inventario();
            inventario.AgregarProductosNuevos(panPerro);
            inventario.AgregarProductosNuevos(queso);
            inventario.AgregarProductosNuevos(salchicha);
            List<ProductoSimple> productos = new List<ProductoSimple>
            {
                queso,
                queso,
                salchicha,
                panPerro
            };
            //Acción
            var compuesto = receta.CrearRecetas(receta, productos,inventario);
            //Verificación
            Assert.AreEqual("No se puede crear la receta, faltan ingredientes", compuesto);
        }

        [TestMethod()]
        public void CrearRecetasTest()
        {
            Assert.Fail();
        }
    }
}