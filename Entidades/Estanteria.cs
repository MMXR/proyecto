using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estanteria : IEquatable<Estanteria>
    {
        public int Idestateria { get; set; }
        public int NumAlturas { get; set; }
        public int NumFilas { get; set; }
        public List<Estante> listaEstantes { get; set; }

        public Estanteria()
        {
        }

        public Estanteria(int idestateria, int numAlturas, int numFilas, List<Estante> listaEstantes)
        {
            Idestateria = idestateria;
            NumAlturas = numAlturas;
            NumFilas = numFilas;
            this.listaEstantes = listaEstantes;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Estanteria);
        }

        public bool Equals(Estanteria other)
        {
            return other != null &&
                   Idestateria == other.Idestateria;
        }

        public override int GetHashCode()
        {
            return -1726190668 + Idestateria.GetHashCode();
        }
    }
}
