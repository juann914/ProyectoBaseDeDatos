using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Databasesproyect
{
    internal class DaoVenta
    {


        public double obenterCliente(string codigoBarra)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();

            string str = "select precio from productos  where codigoBarra=@codigoBarra;";


            MySqlCommand comando = new MySqlCommand(str, conexion);
            comando.Parameters.AddWithValue("@codigoBarra", codigoBarra);

            MySqlDataReader read = comando.ExecuteReader();

            clsCliente cli = null;
            double subtotal = 0;
;            if (read.Read())
            {
                
                cli.idCliente = int.Parse(read["idCliente"].ToString());
                cli.nombre = read["precio"].ToString();
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
