using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;


namespace Databasesproyect
{
    internal class daoClientes
    {
        public clsCliente obenterCliente(string id)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();

            string str = "select idCliente,nombre,apellido,correo,rfc from clientes  where idCliente=@id";


            MySqlCommand comando = new MySqlCommand(str, conexion);
            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader read = comando.ExecuteReader();

            clsCliente cli = null;

            if (read.Read())
            {
                cli = new clsCliente();
                cli.idCliente = int.Parse(read["idCliente"].ToString());
                cli.nombre = read["nombre"].ToString();
                cli.apellidos = read["apellido"].ToString();
                cli.correo = read["correo"].ToString();
                cli.rfc = read["rfc"].ToString();



                conexion.Close();
                comando.Connection.Close();

                return cli;

            }
            conexion.Close();
            comando.Connection.Close();
            return cli;

        }

        public void borrarCliente(String id)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();




            MySqlCommand comando = new MySqlCommand("eliminarClientes", conexion);


            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@c_idCliente", id);



            comando.ExecuteNonQuery();


            conexion.Close();


        }

        public void editarCliente(clsCliente cliente)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);
            conexion.Open();



            MySqlCommand comando = new MySqlCommand("editarClientes", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@c_nombre",cliente.nombre);
            comando.Parameters.AddWithValue("@c_apellido", cliente.apellidos);
            comando.Parameters.AddWithValue("@c_correo", cliente.correo);
            comando.Parameters.AddWithValue("@c_idCliente", cliente.idCliente);
            

            comando.ExecuteNonQuery();


            conexion.Close();

        }


        public clsCliente[] obtenerTodos()
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            MySqlConnection conexion = new MySqlConnection(strConexion);
            conexion.Open();

            string str = "select idCliente,nombre,apellido,correo,rfc from clientes";
            MySqlCommand comando = new MySqlCommand(str, conexion);

            MySqlDataReader read = comando.ExecuteReader();


            List<clsCliente> listaClientes = new List<clsCliente>();

            while (read.Read())
            {
                clsCliente cliente = new clsCliente();
                cliente.idCliente = int.Parse(read["idCliente"].ToString());
                cliente.nombre = read["nombre"].ToString();
                cliente.apellidos = read["apellido"].ToString();
                cliente.correo = read["correo"].ToString() ;
                cliente.rfc = read["rfc"].ToString();
                

                listaClientes.Add(cliente);
            }

            comando.Connection.Close();
            conexion.Close();
            return listaClientes.ToArray();
        }


        public void insertarCliente(clsCliente cliente)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();




            MySqlCommand comando = new MySqlCommand("insertarClientes", conexion);
            comando.CommandType=System.Data.CommandType.StoredProcedure;


            comando.Parameters.AddWithValue("@c_nombre", cliente.nombre);


            comando.Parameters.AddWithValue("@c_apellido", cliente.apellidos);

            comando.Parameters.AddWithValue("@c_correo", cliente.correo);

            comando.Parameters.AddWithValue("@c_rfc", cliente.rfc);

      
            comando.ExecuteNonQuery();


            conexion.Close();



        }





    }

}

