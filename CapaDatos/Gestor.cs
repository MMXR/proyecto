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
        //<<<<<<< HEAD
        public void createProduct() { }
        public String CreateProduct(Producto producto)
// e2eac3eaeac66331b85a2737449565a46c324f64
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
        public List<Producto> SelectCamposProductoFromProducto(int cod)
        {
            Producto p = new Producto();
            List<Producto> productos = new List<Producto>();

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = STRINGCONECT;//CADENA CREADA
                                                       ////PRIMERO SE BUSCA SI EL CONTACTO YA EXISTE-->Escribir la query, abrir conexion, ejecutar comando
                connection.Open(); // abrir conexión

                MySqlCommand mycomand = new MySqlCommand("select * from producto where codigo=@codigo", connection);
                mycomand.Parameters.AddWithValue("@codigo", cod);
                MySqlDataReader reader = mycomand.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.HasRows)
                    {
                        
                        p.Codigo = reader.GetInt32(0);
                        p.Descripcion = reader.ToString(1);
                        p.Precio = reader.ToString(2);
                        p.Stock = reader.ToString(3);
                        p.Subfamilia_codSF = reader.ToString(4);
                        p.Familia_codFamilia = reader.ToString(5);
                        p.Marca_idmarca = reader.ToString(6);
                        p.PesoBruto = reader.ToString(7);
                        p.PesoNeto = reader.ToString(8);
                        productos.Add(p);

                    }

                    List<Producto> productosConEstante = this.SelectProductFromEstante(productos);
                }
            }
           

        }

        public List<Producto> SelectProductFromEstante(List<Producto> lista)
        {
           
            for (int i = 0; i < lista.Count(); i++)
            {
                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = STRINGCONECT;//CADENA CREADA
                                                               ////PRIMERO SE BUSCA SI EL CONTACTO YA EXISTE-->Escribir la query, abrir conexion, ejecutar comando
                    connection.Open(); // abrir conexión
                    Producto p = lista.ElementAt(i);

                    MySqlCommand mycomand = new MySqlCommand("select * from producto_has_estante where producto_codigo=@codigo", connection);
                    mycomand.Parameters.AddWithValue("@codigo", p.Codigo);
                    MySqlDataReader reader = mycomand.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        int a = 0;
                        while (reader.HasRows())
                        {
                            
                            Estante e = new Estante();
                            e.altura = reader.GetInt32(1);
                            e.fila = reader.GetInt32(2);
                            e.idEstanteria = reader.GetInt32(3);
                            lista.ElementAt(a).ListaEstantes.Add(e);
                            a++;
                        }
                    }
                }
            }
            return lista;
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
