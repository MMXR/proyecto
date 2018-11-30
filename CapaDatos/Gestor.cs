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
                cmd.Parameters.AddWithValue("@codigo", producto.CodigoProducto);
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

                        p.CodigoProducto = reader.GetInt32(0);
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
            return productos;

        }

        public List<Producto> SelectProductFromEstante(List<Producto> lista)
        {

            for (int i = 0; i < lista.Count(); i++)
            {
                try {
                    using (MySqlConnection connection = new MySqlConnection())
                    {
                        connection.ConnectionString = STRINGCONECT;//CADENA CREADA
                                                                   ////PRIMERO SE BUSCA SI EL CONTACTO YA EXISTE-->Escribir la query, abrir conexion, ejecutar comando
                        connection.Open(); // abrir conexión
                        Producto p = lista.ElementAt(i);

                        MySqlCommand mycomand = new MySqlCommand("select * from producto_has_estante where producto_codigo=@codigo", connection);
                        mycomand.Parameters.AddWithValue("@codigo", p.CodigoProducto);
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
                catch (Exception e)
                {
                    return null;
                }

            }
            return lista;
        }



        //Update
        public String UpdateProduct(Producto p)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection()) {
                    connection.ConnectionString = STRINGCONECT;
                    connection.Open();


                    MySqlCommand mycomand = new MySqlCommand("select * from producto where codigo=@codigo", connection);
                    mycomand.Parameters.AddWithValue("@codigo", p.CodigoProducto);
                    MySqlDataReader reader = mycomand.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        MySqlCommand mycomand = new MySqlCommand("UPDATE producto SET codigo=@codigo descripcion=@descripcion precio=@precio stock=@stock subfamilia_codSF=@subfamilia subfamilia_familia_codFamilia=@familia marca_idmarca=@marca pesoNeto@pesoneto pesoBruto=@pesoBruto WHERE codigo = @code ", connection);
                        mycomand.Parameters.AddWithValue("@codigo", p.CodigoProducto);
                        mycomand.Parameters.AddWithValue("@descripcion", p.Descripcion);
                        mycomand.Parameters.AddWithValue("@precio", p.Precio);
                        mycomand.Parameters.AddWithValue("@stock", p.Stock);
                        mycomand.Parameters.AddWithValue("@subfamilia_codSF", p.Subfamilia_codSF);
                        mycomand.Parameters.AddWithValue("@subfamilia_familia_codFamilia", p.Familia_codFamilia);
                        mycomand.Parameters.AddWithValue("@marca_idmarca", p.Marca_idmarca);
                        mycomand.Parameters.AddWithValue("@pesoNeto", p.PesoNeto);
                        mycomand.Parameters.AddWithValue("@pesoBruto", p.PesoBruto);
                        mycomand.Parameters.AddWithValue("@code", p.CodigoProducto);

                        MySqlDataReader reader2 = mycomand.ExecuteReader();
                        if (reader2.HasRows())
                        {
                            return "Updateado";
                        }


                    }
                    return "No se ha encontrado el producto."
            }


            }
            catch (Exception e)
            {
                return e.Message;
            }

        }




        //Delete
        public string DeleteProduct(Producto p)
        {

            try
            {
                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = STRINGCONECT;
                    connection.Open();


                    MySqlCommand mycomand = new MySqlCommand("select * from producto where codigo=@codigo", connection);
                    mycomand.Parameters.AddWithValue("@codigo", p.CodigoProducto);
                    MySqlDataReader reader = mycomand.ExecuteReader();
                    if (reader.HasRows == true)
                    {

                        connection.Close();

                        try
                        {
                            using (MySqlConnection connection = new MySqlConnection())
                            {
                                connection.ConnectionString = STRINGCONECT;
                                connection.Open();


                                MySqlCommand mycomand = new MySqlCommand("delete from producto where codigo=@codigo", connection);
                                mycomand.Parameters.AddWithValue("@codigo", p.CodigoProducto);
                                MySqlDataReader reader2 = mycomand.ExecuteReader();
                                if (reader2.HasRows())
                                {
                                    return "Deleted";
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            return e.Message;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "borrado";

    }
    }
}
