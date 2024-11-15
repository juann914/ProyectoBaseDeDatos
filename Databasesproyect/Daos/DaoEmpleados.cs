using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Databasesproyect;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;


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

        public void modificarEmpleado(clsEmpleados empleado)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            MySqlConnection conexion = new MySqlConnection(strConexion);
            conexion.Open();
            string strInsert = "update empleados set clave =@clave, username = @username, nombre = @nombre, apellido=@apellido, telefono=@telefono, curp=@curp, edad=@edad where idEmpleado = @id";

            MySqlCommand comando = conexion.CreateCommand();
            comando.Parameters.AddWithValue("@clave", empleado.clave);
            comando.Parameters.AddWithValue("@username", empleado.username);
            comando.Parameters.AddWithValue("@nombre", empleado.nombre);
            comando.Parameters.AddWithValue("@apellido", empleado.apellido);
            comando.Parameters.AddWithValue("@telefono", empleado.telefono);
            comando.Parameters.AddWithValue("@curp", empleado.curp);
            comando.Parameters.AddWithValue("@edad", empleado.edad);
            comando.Parameters.AddWithValue("@id", empleado.idEmpleado);
            comando.CommandText = strInsert;

            comando.ExecuteNonQuery();

            conexion.Close();

        }

        public void eliminarEmpleado(clsEmpleados empleado)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            MySqlConnection conexion = new MySqlConnection(strConexion);
            conexion.Open();

            string strDelete = "delete from empleados where idEmpleado=@id";

            MySqlCommand comando = conexion.CreateCommand();

            comando.Parameters.AddWithValue("@id", empleado.idEmpleado);

            comando.CommandText = strDelete;

            comando.ExecuteNonQuery();

            conexion.Close();

        }

        public clsEmpleados consultarEmpleado(int idEmpleado)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            using (MySqlConnection conexion = new MySqlConnection(strConexion))
            {
                conexion.Open();
                string strConsulta = "SELECT * FROM empleados WHERE idEmpleado = @id";
                using (MySqlCommand comando = new MySqlCommand(strConsulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idEmpleado);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        clsEmpleados emp = new clsEmpleados();
                        if (reader.Read())
                        {
                            emp.idEmpleado = reader.GetInt32("idEmpleado");
                            emp.clave = reader.GetString("clave");
                            emp.username = reader.GetString("username");
                            emp.nombre = reader.GetString("nombre");
                            emp.apellido = reader.GetString("apellido");
                            emp.telefono = reader.GetString("telefono");
                            emp.curp = reader.GetString("curp");
                            emp.edad = reader.GetInt32("edad");
                        }
                        return emp;
                    }
                }
            }

        }



    }
    }
