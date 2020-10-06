using System;
using System.Collections.Generic;
using System.Text;

namespace ComidasRapidas
{
    public class ProductoCompuesto : Producto
    {

        

        public ProductoCompuesto(string id, string nombre, decimal precio, decimal costo) : base(id, nombre, precio, costo)
        {

        }


        public string CrearRecetas(ProductoCompuesto producto, List<ProductoSimple> ingredientes, Inventario inventario)
        {
            return inventario.SacarProductos(producto,ingredientes);

        }
    }
}
