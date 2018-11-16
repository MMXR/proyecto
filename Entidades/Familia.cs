using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Familia : IEquatable<Familia>
    {
        public int codFamilia { get; set; }
        public String idString { get; set; }
        public String descripcion { get; set; }

        public Familia(int codFamilia, string idString, string descripcion)
        {
            this.codFamilia = codFamilia;
            this.idString = idString;
            this.descripcion = descripcion;
        }

        public Familia()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Familia);
        }

        public bool Equals(Familia other)
        {
            return other != null &&
                   codFamilia == other.codFamilia;
        }

        public override int GetHashCode()
        {
            return 910640060 + codFamilia.GetHashCode();
        }
    }

}
