using System;
using System.Collections.Generic;
using System.Linq;

namespace ComidasRapidas
{
    public class Invetario
    {
        public List<ProductoSimple> Bodega { get; set; }

        public Invetario()
        {
        }

        public Invetario(List<ProductoSimple> bodega)
        {
            Bodega = bodega;
        }

        public string AgregarProductos(ProductoSimple product)
        {
            string result = "";
            try
            {
                if (product.Cantidad <= 0)
                    return "La cantidad de prodcuto no es validad, verifique.";

                var _position = Bodega.FindIndex(val => val.ID == product.ID);
                Console.WriteLine(_position.ToString()+"-------------------------------------------");
                if (true)
                {
                    //Console.WriteLine(Bodega.Count.ToString() + "jjjkkkkkkkkjjj");
                    Bodega.Add(product);
                }
                else
                {
                    Bodega[_position].Cantidad += product.Cantidad;
                }
                
                result = "El producto " + Bodega[Bodega.Count-1].Nombre + $" con el precio de: ${Bodega[Bodega.Count - 1].Precio:n2} y la cantidad de: "+ Bodega[Bodega.Count - 1].Cantidad;
            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
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
