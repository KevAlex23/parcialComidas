using System;
using System.Collections.Generic;
using System.Text;

namespace ComidasRapidas
{
    public class ProductoSimple : Producto
    {
        public int Cantidad { get; set; }

        public ProductoSimple(string id, string nombre, decimal precio, decimal costo, int cantidad): base (id,nombre,precio,costo)
        {
            Cantidad = cantidad;
        }
    }
}
