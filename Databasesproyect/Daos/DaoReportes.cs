using Databasesproyect.Clases;
using MySql.Data.MySqlClient;
using ProyectoDeBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databasesproyect.Daos
{
    internal class DaoReportes
    {
        public List<ClsVentasPorTrimestre> ObtenerVentasPorTrimestre(int anio)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            List<ClsVentasPorTrimestre> listaVentas = new List<ClsVentasPorTrimestre>();

            using (MySqlConnection conexion = new MySqlConnection(strConexion))
            {
                conexion.Open();
                string strConsulta = "SELECT * FROM ventas_pivot_trimestres WHERE Año = @anio";
                using (MySqlCommand comando = new MySqlCommand(strConsulta, conexion))
                {
                    comando.Parameters.AddWithValue("@anio", anio);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClsVentasPorTrimestre venta = new ClsVentasPorTrimestre
                            {
                                Producto = reader.GetString("Producto"),
                                Año = reader.GetInt32("Año"),
                                Trimestre1 = reader.GetInt32("Trimestre_1"),
                                Trimestre2 = reader.GetInt32("Trimestre_2"),
                                Trimestre3 = reader.GetInt32("Trimestre_3"),
                                Trimestre4 = reader.GetInt32("Trimestre_4")
                            };
                            listaVentas.Add(venta);
                        }
                    }
                }
            }

            return listaVentas;
        }

    }
}
