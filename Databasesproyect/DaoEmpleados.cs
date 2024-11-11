using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Databasesproyect;
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

        public void insertarEmpleado(clsEmpleados empleado)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            MySqlConnection conexion = new MySqlConnection(strConexion);
            conexion.Open();

            string strInsert = "insert into empleados values (null,@clave,@username,@nombre,@apellido,@telefono,@curp,@edad)";

            MySqlCommand comando = conexion.CreateCommand();

            comando.Parameters.AddWithValue("@clave", empleado.clave);
            comando.Parameters.AddWithValue("@username", empleado.username);
            comando.Parameters.AddWithValue("@nombre", empleado.nombre);
            comando.Parameters.AddWithValue("@apellido", empleado.apellido);
            comando.Parameters.AddWithValue("@telefono", empleado.telefono);
            comando.Parameters.AddWithValue("@curp", empleado.curp);
            comando.Parameters.AddWithValue("@edad", empleado.edad);

            comando.CommandText = strInsert;

            MySqlDataReader reader = comando.ExecuteReader();

            conexion.Close();

        }

        public DataTable cargarEmpleados()
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            MySqlConnection conexion = new MySqlConnection(strConexion);
            conexion.Open();

            DataTable tablaEmpleados = new DataTable();
            string query = "SELECT * FROM empleados";

            MySqlCommand comando = new MySqlCommand(query, conexion);

            
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(tablaEmpleados);

            
            return tablaEmpleados;

            conexion.Close();

        }

    }
    }
