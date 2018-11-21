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
        public void createProduct(Producto p)
        {

        }

        //Read-->Opciones varias
        public List<Producto> selectProductNombre(String name)
        {
            List<Producto> productos = new List<Producto>();
            return productos;
        }

        public void selectProductCode(String code)
        {

        }

        public void selectAllProducts()
        {

        }

        //Update
        public void updateProduct(Producto p)
        {

        }

        //Delete
        public void deleteProduct(Producto p)
        {
            p.PesoNeto = 0;
        }

    }
}
