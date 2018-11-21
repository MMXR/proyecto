using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Marca : IEquatable<Marca>
    {
        public int idmarca { get; set; }
        public String nombre { get; set; }
        public List<Producto> listaProductos { get; set; }

        public Marca(int idmarca, string nombre, List<Producto> listaProductos)
        {
            this.idmarca = idmarca;
            this.nombre = nombre;
            this.listaProductos = listaProductos;
        }

        public Marca()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Marca);
        }

        public bool Equals(Marca other)
        {
            return other != null &&
                   idmarca == other.idmarca;
        }

        public override int GetHashCode()
        {
            return -272442024 + idmarca.GetHashCode();
        }
    }
}
