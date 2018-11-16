﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : IEquatable<Producto>
    {
        public Producto()
        {
        }

        public Producto(string codigo, string ean, string descripcion, string marca, string precio, int stock, int subfamilia_codSF, int subfamilia_familia_codFamilia, int marca_idmarca, double pesoNeto, double pesoBruto)
        {
            Codigo = codigo;
            Ean = ean;
            Descripcion = descripcion;
            Marca = marca;
            Precio = precio;
            Stock = stock;
            Subfamilia_codSF = subfamilia_codSF;
            Subfamilia_familia_codFamilia = subfamilia_familia_codFamilia;
            Marca_idmarca = marca_idmarca;
            PesoNeto = pesoNeto;
            PesoBruto = pesoBruto;
        }

        public string Codigo { get; set; }
        public string Ean { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Precio { get; set; }
        public int Stock { get; set; }
        public int Subfamilia_codSF { get; set; }
        public int Subfamilia_familia_codFamilia { get; set; }
        public int Marca_idmarca { get; set; }
        public double PesoNeto { get; set; }
        public double PesoBruto { get; set; }

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