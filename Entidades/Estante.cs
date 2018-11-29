using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante : IEquatable<Estante>
    {
        public int altura { get; set; }
        public int fila { get; set; }
        public int idEstanteria { get; set; }
        public List<Producto> listaProductos { get; set; }

        public Estante(int altura, int fila, int idEstanteria, List<Producto> listaProductos)
        {
            this.altura = altura;
            this.fila = fila;
            this.idEstanteria = idEstanteria;
            this.listaProductos = listaProductos;
        }

        public Estante()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Estante);
        }

        public bool Equals(Estante other)
        {
            return other != null &&
                   altura == other.altura &&
                   fila == other.fila &&
                   idEstanteria == other.idEstanteria;
        }

        public override int GetHashCode()
        {
            var hashCode = 1381946389;
            hashCode = hashCode * -1521134295 + altura.GetHashCode();
            hashCode = hashCode * -1521134295 + fila.GetHashCode();
            hashCode = hashCode * -1521134295 + idEstanteria.GetHashCode();
            return hashCode;
        }
    }
}
