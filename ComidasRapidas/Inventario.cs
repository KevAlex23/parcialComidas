using System;
using System.Collections.Generic;
using System.Linq;

namespace ComidasRapidas
{
    public class Inventario
    {
        public List<ProductoSimple> Bodega = new List<ProductoSimple>();

        public Inventario()
        {
        }



        public string AgregarProductosNuevos(ProductoSimple product)
        {
            string _result = "";
            try
            {
                if (product.Cantidad <= 0)
                    return "La cantidad de prodcuto no es validad, verifique.";


                if (AgregarProductos(product.ID, product.Cantidad) == "El producto solicitado no existe")
                {
                    Bodega.Add(product);
                }
                Console.WriteLine(Bodega[Bodega.Count - 1].Nombre);
                _result = $"El producto " + Bodega[Bodega.Count-1].Nombre + $" con el precio de: ${Bodega[Bodega.Count -1].Precio:n2} y la cantidad de: "+ Bodega[Bodega.Count-1].Cantidad;
            }
            catch (Exception e)
            {
                _result = e.Message;
            }

            return _result;
        }

        public string AgregarProductos(string id, int cantidad)
        {
            string _result = "";
            try
            {
                var _position = Bodega.FindIndex(val => val.ID == id);
                Console.WriteLine(_position);
                if (_position == -1)
                    return "El producto solicitado no existe";
                Console.WriteLine(_position.ToString()+"--------------");
                int cantidadAnterior = Bodega[_position].Cantidad;
                Bodega[_position].Cantidad += cantidad;
                _result = "Se actualizo el producto: " + Bodega[_position].Nombre + " cantidad anterior: " + cantidadAnterior+", Cantidad actual: "+ Bodega[_position].Cantidad;
            }
            catch (Exception e)
            {
                _result = e.Message;
            }
            return _result;
        }

        public string SalidaProductos(string id, int cantidad)
        {
            string _result = "";

            try
            {
                foreach (var item in Bodega)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
            if (Bodega.Find(val => val.ID == id) == null)
                return "El producto solicitado no existe";

            Bodega.Find(val => val.ID == id);
            return _result;
        }

        public string SacarProductos(ProductoCompuesto producto,List<ProductoSimple> ingredientes)
        {
            
            if (ValidaCantidad(ingredientes))
                return "No se puede crear la receta, faltan ingredientes";

            foreach (var item in ingredientes)
            {
                Bodega.Find(val => val.ID == item.ID).Cantidad -= item.Cantidad;
            }

            return "Se creo la nueva receta: "+producto.Nombre;
        }

        private bool ValidaCantidad(List<ProductoSimple> ingredientes)
        {
            bool value = true;
            foreach (var item in ingredientes)
            {
                Console.WriteLine(item.Cantidad.ToString());
                Console.WriteLine(Bodega.Count.ToString());

                if (Bodega.Find(val => val.ID == item.ID).Cantidad < item.Cantidad)
                {
                    return false;
                }
            }
            return value;
        }

    }
}
