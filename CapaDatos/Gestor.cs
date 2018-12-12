using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos
{
    public class Gestor
    {
        static String STRINGCONECT = "SERVER=localhost;DATABASE=agenda;UID=root;PASSWORD=" + "" + ";";
        //CRUD Producto
        //<<<<<<< HEAD
        public String CreateProduct(Producto producto)
        // e2eac3eaeac66331b85a2737449565a46c324f64
        {
            if (!(Double.TryParse(producto.Precio, out double number)))
            {
                return "El precio debe ser un número";
            }

            try
            {
                //Conexion a la base de datos
                MySqlConnection connection = new MySqlConnection(STRINGCONECT);
                MySqlCommand cmd = connection.CreateCommand();
                connection.Open();

                MySqlCommand mycomand = new MySqlCommand("select * from producto where codigo=@codigo", connection);
                mycomand.Parameters.AddWithValue("@codigo", producto.CodigoProducto);
                MySqlDataReader reader = mycomand.ExecuteReader();
                if (reader.HasRows == true)
                {
                    return "El producto ya existe";
                }
                reader.Close();

                cmd.CommandText = "INSERT INTO producto (codigo,descripcion,precio,stock,subfamilia_codSF,subfamilia_familia_codFamilia,marca_idmarca,pesoNeto,pesoBruto) value (@codigo, @descripcion, @precio, @stock, @codFamilia, @codSubFamilia, @marca, @pesoNeto, @pesoBruto)";
                cmd.Parameters.AddWithValue("@codigo", producto.CodigoCompleto);
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

            }
            catch (Exception e)
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

                        p.CodigoProducto = reader.GetString(0);
                        p.Descripcion = reader.GetString(1);
                        p.Precio = reader.GetString(2);
                        Int32.TryParse(reader.GetString(3), out int stock);
                        p.Stock = stock;
                        Int32.TryParse(reader.GetString(4), out int codSF);
                        p.Subfamilia_codSF = codSF;
                        Int32.TryParse(reader.GetString(5), out int Codf);
                        p.Familia_codFamilia = Codf;
                        Int32.TryParse(reader.GetString(6), out int idmarca);
                        p.Marca_idmarca = idmarca;
                        p.PesoBruto = reader.GetString(7);
                        p.PesoNeto = reader.GetString(8);
                        productos.Add(p);

                    }

                    List<Producto> productosConEstante = this.SelectProductFromEstante(productos);
                }
            }
            return productos;

        }
        public String SelectProductoMarca(int i, int marca)
        {
            String nombreProducto = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = STRINGCONECT;//CADENA CREADA
                                                               ////PRIMERO SE BUSCA SI EL CONTACTO YA EXISTE-->Escribir la query, abrir conexion, ejecutar comando
                    connection.Open(); // abrir conexión
                    int j = 0;
                    MySqlCommand mycomand = new MySqlCommand("select * from producto where marca_idmarca=@marca", connection);
                    mycomand.Parameters.AddWithValue("@marca", marca);
                    MySqlDataReader reader = mycomand.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            j = j + 1;
                            if (j == i)
                            {
                                nombreProducto = (String)reader["descripcion"];
                            }
                        }

                    }
                }
            }
            catch (Exception e)
            {
                return "";
            }
            return nombreProducto;
        }
        public int SelectCountProductosMarca(int marca)
        {
            int cantidad = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = STRINGCONECT;//CADENA CREADA
                                                               ////PRIMERO SE BUSCA SI EL CONTACTO YA EXISTE-->Escribir la query, abrir conexion, ejecutar comando
                    MySqlCommand mycomand = new MySqlCommand();
                    mycomand.Connection = connection;
                    connection.Open(); // abrir conexión
                    mycomand.CommandText = "select COUNT(*) from producto where marca_idmarca=@marca";
                    mycomand.Parameters.AddWithValue("@marca", marca);
                    cantidad = Convert.ToInt32(mycomand.ExecuteScalar());
                }
            }
            catch (Exception e)
            {
                return 0;
            }
            return cantidad;
        }
        public List<Producto> SelectProductFromEstante(List<Producto> lista)
        {

            for (int i = 0; i < lista.Count(); i++)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection())
                    {
                        connection.ConnectionString = STRINGCONECT;//CADENA CREADA
                                                                   ////PRIMERO SE BUSCA SI EL CONTACTO YA EXISTE-->Escribir la query, abrir conexion, ejecutar comando
                        connection.Open(); // abrir conexión
                        Producto p = lista.ElementAt(i);

                        MySqlCommand mycomand = new MySqlCommand("select * from producto_has_estante where producto_codigo=@codigo", connection);
                        mycomand.Parameters.AddWithValue("@codigo", p.CodigoCompleto);
                        MySqlDataReader reader = mycomand.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            int a = 0;
                            while (reader.Read())
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
                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = STRINGCONECT;
                    connection.Open();


                    MySqlCommand mycomand = new MySqlCommand("select * from producto where codigo=@codigo", connection);
                    mycomand.Parameters.AddWithValue("@codigo", p.CodigoCompleto);
                    MySqlDataReader reader = mycomand.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        MySqlCommand mycomand2 = new MySqlCommand("UPDATE producto SET codigo=@codigo descripcion=@descripcion precio=@precio stock=@stock subfamilia_codSF=@subfamilia subfamilia_familia_codFamilia=@familia marca_idmarca=@marca pesoNeto@pesoneto pesoBruto=@pesoBruto WHERE codigo = @code ", connection);
                        mycomand2.Parameters.AddWithValue("@codigo", p.CodigoProducto);
                        mycomand2.Parameters.AddWithValue("@descripcion", p.Descripcion);
                        mycomand2.Parameters.AddWithValue("@precio", p.Precio);
                        mycomand2.Parameters.AddWithValue("@stock", p.Stock);
                        mycomand2.Parameters.AddWithValue("@subfamilia_codSF", p.Subfamilia_codSF);
                        mycomand2.Parameters.AddWithValue("@subfamilia_familia_codFamilia", p.Familia_codFamilia);
                        mycomand2.Parameters.AddWithValue("@marca_idmarca", p.Marca_idmarca);
                        mycomand2.Parameters.AddWithValue("@pesoNeto", p.PesoNeto);
                        mycomand2.Parameters.AddWithValue("@pesoBruto", p.PesoBruto);
                        mycomand2.Parameters.AddWithValue("@code", p.CodigoProducto);

                    }
                    return "No se ha encontrado el producto.";
                }


            }
            catch (Exception e)
            {
                return e.Message;
            }

        }




        //Delete
        public string DeleteProduct(String p, int marca)
        {

            try
            {

                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = STRINGCONECT;
                    connection.Open();
                    MySqlCommand mycomando = new MySqlCommand("delete from producto where descripcion=@des and marca_idmarca=@marca", connection);
                    mycomando.Parameters.AddWithValue("@marca", marca);
                    mycomando.Parameters.AddWithValue("@des", p);
                    mycomando.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";

        }
        //CRUD EMPRESA
        public String SelectNombreMarca(int i)
        {
            String nombreEmpresa = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = STRINGCONECT;//CADENA CREADA
                                                               ////PRIMERO SE BUSCA SI EL CONTACTO YA EXISTE-->Escribir la query, abrir conexion, ejecutar comando
                    connection.Open(); // abrir conexión
                    int j = 0;
                    MySqlCommand mycomand = new MySqlCommand("select * from marca", connection);
                    MySqlDataReader reader = mycomand.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            j = j + 1;
                            if (j == i)
                            {
                                nombreEmpresa = (String)reader["nombre"];
                            }
                        }

                    }
                }
            }
            catch (Exception e)
            {
                return "";
            }
            return nombreEmpresa;
        }
        public int SelectIDMarca(String nombre)
        {
            int id = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = STRINGCONECT;//CADENA CREADA
                                                               ////PRIMERO SE BUSCA SI EL CONTACTO YA EXISTE-->Escribir la query, abrir conexion, ejecutar comando
                    connection.Open(); // abrir conexión
                    int j = 0;
                    MySqlCommand mycomand = new MySqlCommand("select * from marca where nombre=@nombre", connection);
                    mycomand.Parameters.AddWithValue("@nombre", nombre);
                    MySqlDataReader reader = mycomand.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        if (reader.Read())
                        {
                            id = (int)reader["idmarca"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return 0;
            }
            return id;
        }
        public int SelectCountCantidadMarcas()
        {
            int cantidad = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection())
                {
                    connection.ConnectionString = STRINGCONECT;//CADENA CREADA
                                                               ////PRIMERO SE BUSCA SI EL CONTACTO YA EXISTE-->Escribir la query, abrir conexion, ejecutar comando
                    MySqlCommand mycomand = new MySqlCommand();
                    mycomand.Connection = connection;
                    connection.Open(); // abrir conexión
                    mycomand.CommandText = "select COUNT(*) from marca";
                    cantidad = Convert.ToInt32(mycomand.ExecuteScalar());
                }
            }
            catch (Exception e)
            {
                return 0;
            }
            return cantidad;
        }
    }
}
