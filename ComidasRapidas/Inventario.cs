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


                if (AgregarProductos(product.ID, product.Cantidad) == "No hay productos con ese id")
                {
                    Bodega.Add(product);
                }
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
                if (_position == -1)
                    return "El producto solicitado no existe";
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

        public string QuitarProductos(string id, int cantidad)
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


    }
}
