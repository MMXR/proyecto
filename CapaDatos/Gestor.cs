using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Gestor
    {

        //CRUD Producto
        public void CreateProduct(Producto p)
        {

        }

        //Read-->Opciones varias
        public List<Producto> SelectProductNombre(String name)
        {

            List<Producto> productos = new List<Producto>();
            return productos;
        }

        public void SelectProductCode(String code)
        {

        }

        public void SelectAllProducts()
        {

        }

        //Update
        public void UpdateProduct(Producto p)
        {

        }

        //Delete
        public void DeleteProduct(Producto p)
        {
            p.PesoNeto = 0;
        }

    }
}
