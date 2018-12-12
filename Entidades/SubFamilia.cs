using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SubFamilia : IEquatable<SubFamilia>
    {
        public int codSF { get; set; }
        public String idCaracter { get; set; }
        public String descripcion { get; set; }
        public int codFamilia { get; set; }


        public SubFamilia(int codSF, string idCaracter, string descripcion, int codFamilia)
        {
            this.codSF = codSF;
            this.idCaracter = idCaracter;
            this.descripcion = descripcion;
            this.codFamilia = codFamilia;
        }

        public SubFamilia()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as SubFamilia);
        }

        public bool Equals(SubFamilia other)
        {
            return other != null &&
                   codSF == other.codSF &&
                   idCaracter == other.idCaracter &&
                   descripcion == other.descripcion &&
                   codFamilia == other.codFamilia;
        }

        public override int GetHashCode()
        {
            var hashCode = -104265189;
            hashCode = hashCode * -1521134295 + codSF.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(idCaracter);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(descripcion);
            hashCode = hashCode * -1521134295 + codFamilia.GetHashCode();
            return hashCode;
        }
    }
}
