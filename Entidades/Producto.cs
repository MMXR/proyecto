using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : IEquatable<Producto>
    {
        public string CodigoProducto { get; set; }
        public string CodigoCompleto { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public int Stock { get; set; }
        public int Subfamilia_codSF { get; set; }
        public int Familia_codFamilia { get; set; }
        public int Marca_idmarca { get; set; }
        public string PesoNeto { get; set; }
        public string PesoBruto { get; set; }
        public List<Estante> ListaEstantes { get; set; }

        public Producto()
        {
        }

        public Producto(string codigoproducto, string descripcion, string precio, int stock, int subfamilia_codSF, int familia_codFamilia, int marca_idmarca, string pesoNeto, string pesoBruto, List<Estante> listaEstantes)
        {
            CodigoProducto = codigoproducto;
            CodigoCompleto = "22"+"31012"+Familia_codFamilia+ Subfamilia_codSF+codigoproducto;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
            Subfamilia_codSF = subfamilia_codSF;
            Familia_codFamilia = familia_codFamilia;
            Marca_idmarca = marca_idmarca;
            PesoNeto = pesoNeto;
            PesoBruto = pesoBruto;
            ListaEstantes = listaEstantes;
        }
        public Producto(string codigoproducto, string descripcion, string precio, int stock, int subfamilia_codSF, int familia_codFamilia, int marca_idmarca, string pesoNeto, string pesoBruto)
        {
            CodigoProducto = codigoproducto;
            CodigoCompleto = "22" + "31012" + Familia_codFamilia + Subfamilia_codSF + codigoproducto;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
            Subfamilia_codSF = subfamilia_codSF;
            Familia_codFamilia = familia_codFamilia;
            Marca_idmarca = marca_idmarca;
            PesoNeto = pesoNeto;
            PesoBruto = pesoBruto;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Producto);
        }

        public bool Equals(Producto other)
        {
            return other != null &&
                   CodigoProducto == other.CodigoProducto &&
                   Subfamilia_codSF == other.Subfamilia_codSF &&
                   Familia_codFamilia == other.Familia_codFamilia;
        }

        public override int GetHashCode()
        {
            var hashCode = 855614290;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CodigoProducto);
            hashCode = hashCode * -1521134295 + Subfamilia_codSF.GetHashCode();
            hashCode = hashCode * -1521134295 + Familia_codFamilia.GetHashCode();
            return hashCode;
        }
    }
}
