using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cliente : IEquatable<Cliente>
    {

        public String nif { get; set; }
        public String nombre { get; set; }
        public String direccion { get; set; }
        public String lugarEntrega { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nif, string nombre, string direccion, string lugarEntrega)
        {
            this.nif = nif;
            this.nombre = nombre;
            this.direccion = direccion;
            this.lugarEntrega = lugarEntrega;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Cliente);
        }

        public bool Equals(Cliente other)
        {
            return other != null &&
                   nif == other.nif;
        }

        public override int GetHashCode()
        {
            return -1298672326 + EqualityComparer<string>.Default.GetHashCode(nif);
        }
    }


}
