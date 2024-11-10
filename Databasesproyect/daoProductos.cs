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
         
            string strInsert = "insert into productos values (null,@codigoBarra,@nombre,@precio,@marca)";


            MySqlCommand comando = conexion.CreateCommand();


            comando.Parameters.AddWithValue("@codigoBarra", producto.codigoBarra);


            comando.Parameters.AddWithValue("@nombre", producto.nombre);

            comando.Parameters.AddWithValue("@precio", producto.precio);

            comando.Parameters.AddWithValue("@marca",producto.marca);

            comando.CommandText = strInsert;


            comando.ExecuteNonQuery();


            conexion.Close();



        }
    }
}
