using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Estanteria : IEquatable<Estanteria>
    {
        public Estanteria()
        {
        }

        public Estanteria(int idestateria, int numAlturas, int numFilas)
        {
            Idestateria = idestateria;
            NumAlturas = numAlturas;
            NumFilas = numFilas;
        }

        public int Idestateria { get; set; }
        public int NumAlturas { get; set; }
        public int NumFilas { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Estanteria);
        }

        public bool Equals(Estanteria other)
        {
            return other != null &&
                   Idestateria == other.Idestateria &&
                   NumAlturas == other.NumAlturas &&
                   NumFilas == other.NumFilas;
        }

        public override int GetHashCode()
        {
            var hashCode = -393419837;
            hashCode = hashCode * -1521134295 + Idestateria.GetHashCode();
            hashCode = hashCode * -1521134295 + NumAlturas.GetHashCode();
            hashCode = hashCode * -1521134295 + NumFilas.GetHashCode();
            return hashCode;
        }
    }
}
