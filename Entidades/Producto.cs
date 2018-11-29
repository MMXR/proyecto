using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : IEquatable<Producto>
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public int Stock { get; set; }
        public int Subfamilia_codSF { get; set; }
        public int Familia_codFamilia { get; set; }
        public int Marca_idmarca { get; set; }
        public double PesoNeto { get; set; }
        public double PesoBruto { get; set; }
        public List<Estante> ListaEstantes { get; set; }

        public Producto()
        {
        }

        public Producto(string codigo, string descripcion, string precio, int stock, int subfamilia_codSF, int familia_codFamilia, int marca_idmarca, double pesoNeto, double pesoBruto)
        {
            Codigo = codigo;
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
                   Codigo == other.Codigo;
        }

        public override int GetHashCode()
        {
            return 1745598366 + EqualityComparer<string>.Default.GetHashCode(Codigo);
        }
    }
}
