using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ProyectoDeBaseDeDatos
{
    internal class DaoEmpleados
    {

        public bool verificar(string usuario, string password)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            MySqlConnection conexion = new MySqlConnection(strConexion);
            conexion.Open();

            string sql = "Select * from empleados where username=@usuario and clave =@password";

            MySqlCommand comando = new MySqlCommand(sql, conexion);


            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@password", password);

            MySqlDataReader read = comando.ExecuteReader();

            if (read.Read())
            {
                conexion.Close();
                return true;
            }
            else
            {
                conexion.Close();
                return false;
            }

        }

        }
    }
