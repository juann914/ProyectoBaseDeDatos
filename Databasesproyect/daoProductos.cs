using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Databasesproyect
{
    internal class daoProductos
    {

        public void insertarProductos(clsProductos producto)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();

            string strInsert = "insert into productos values (null,@codigoBarra,@nombre,@precio,@marca,@descripcion)";


            MySqlCommand comando = conexion.CreateCommand();


            comando.Parameters.AddWithValue("@codigoBarra", producto.codigoBarra);


            comando.Parameters.AddWithValue("@nombre", producto.nombre);

            comando.Parameters.AddWithValue("@precio", producto.precio);

            comando.Parameters.AddWithValue("@marca", producto.marca);

            comando.Parameters.AddWithValue("@descripcion", producto.descripcion);

            comando.CommandText = strInsert;


            comando.ExecuteNonQuery();


            conexion.Close();



        }


        public clsProductos obtenerCodigo(String code)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();

            string str = "select idProducto,codigoBarra,nombre,precio,marca,descripcion from productos where codigoBarra=@code";


            MySqlCommand comando = new MySqlCommand(str,conexion);
            comando.Parameters.AddWithValue("@code", code);

            MySqlDataReader read = comando.ExecuteReader();

            clsProductos pro = null;

            if (read.Read())
            {
                pro = new clsProductos();
                pro.idProducto = int.Parse(read["idProducto"].ToString());
                pro.codigoBarra = read["codigoBarra"].ToString();
                pro.nombre = read["nombre"].ToString();
                pro.precio = double.Parse(read["precio"].ToString());
                pro.marca = read["marca"].ToString();
                pro.descripcion = read["descripcion"].ToString();
              conexion.Close() ;
               comando.Connection.Close();

                return pro;
                
            }
            conexion.Close();
            comando.Connection.Close();
            return pro;

        }

        public void borrarProducto(String code)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();

            string strInsert = "delete from productos where codigoBarra=@code";


            MySqlCommand comando = conexion.CreateCommand();


            comando.Parameters.AddWithValue("@code",code);


          
            comando.CommandText = strInsert;


            comando.ExecuteNonQuery();


            conexion.Close();


        }
    
    } 




}
