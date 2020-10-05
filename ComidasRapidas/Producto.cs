using System;
using System.Collections.Generic;
using System.Text;

namespace ComidasRapidas
{
    public abstract class Producto
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }

        protected Producto(string id, string nombre, decimal precio, decimal costo)
        {
            ID = id;
            Nombre = nombre;
            Precio = precio;
            Costo = costo;
        }


    }
}
