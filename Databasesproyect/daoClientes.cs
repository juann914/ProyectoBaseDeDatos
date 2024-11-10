﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
    }

    }

