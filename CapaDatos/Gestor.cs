using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
namespace CapaDatos
{
    public class Gestor
    {
        static String STRINGCONECT = "SERVER=localhost;DATABASE=agenda;UID=root;PASSWORD=" + "" + ";";
        //CRUD Producto
        public String CreateProduct(Producto producto)
        {
            try
            {
                //Conexion a la base de datos
                MySqlConnection connection = new MySqlConnection(STRINGCONECT);
                MySqlCommand cmd = connection.CreateCommand();
                connection.Open();

                MySqlCommand mycomand = new MySqlCommand("select * from producto where codigo=@codigo", connection);
                mycomand.Parameters.AddWithValue("@nombre", producto.Codigo);
                MySqlDataReader reader = mycomand.ExecuteReader();
                if (reader.HasRows == true)
                {
                    return "El producto ya existe";
                }
                reader.Close();

                cmd.CommandText = "INSERT INTO producto (codigo,descripcion,precio,stock,subfamilia_codSF,subfamilia_familia_codFamilia,marca_idmarca,pesoNeto,pesoBruto) value (@codigo, @descripcion, @precio, @stock, @codFamilia, @codSubFamilia, @marca, @pesoNeto, @pesoBruto)";
                cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@codFamilia", producto.Familia_codFamilia);
                cmd.Parameters.AddWithValue("@codSubFamilia", producto.Subfamilia_codSF);
                cmd.Parameters.AddWithValue("@estantes", producto.ListaEstantes);
                cmd.Parameters.AddWithValue("@marca", producto.Marca_idmarca);
                cmd.Parameters.AddWithValue("@pesoBruto", producto.PesoBruto);
                cmd.Parameters.AddWithValue("@pesoNeto", producto.PesoNeto);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.ExecuteNonQuery();
                connection.Close();
                return "Datos insertados con éxito";

            } catch (Exception e)
            {
                    return e.ToString();
                
            }

        }

        //Read-->Opciones varias
        public List<Producto> SelectProductNombre(String name)
        {

            List<Producto> productos = new List<Producto>();
            return productos;
        }

        public void SelectProductCode(String code)
        {

        }

        public void SelectAllProducts()
        {

        }

        //Update
        public void UpdateProduct(Producto p)
        {

        }

        //Delete
        public void DeleteProduct(Producto p)
        {
            p.PesoNeto = 0;
        }

    }
}
