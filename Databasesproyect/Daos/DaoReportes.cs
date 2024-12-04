using Databasesproyect.Clases;
using Databasesproyect.Vistas;
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

        public List<ClsVentasPorMes> ObtenerVentasPorMes(DateTime fecha1, DateTime fecha2)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            List<ClsVentasPorMes> listaVentas = new List<ClsVentasPorMes>();

            using (MySqlConnection conexion = new MySqlConnection(strConexion))
            {
                conexion.Open();
                string strConsulta = "SELECT * FROM reporte_mensual WHERE fecha BETWEEN @fecha1 AND @fecha2";
                using (MySqlCommand comando = new MySqlCommand(strConsulta, conexion))
                {
                    comando.Parameters.AddWithValue("@fecha1", fecha1);
                    comando.Parameters.AddWithValue("@fecha2", fecha2);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClsVentasPorMes venta = new ClsVentasPorMes
                            {
                                folio = reader.GetInt32("folio"),
                                fecha = reader.GetDateTime("fecha"),
                                cliente = reader.GetString("cliente"),
                                empleado = reader.GetString("empleado"),
                                total = reader.GetDecimal("total"),
                                cantidad = reader.GetInt32("cantidad")
                            };
                            listaVentas.Add(venta);
                        }
                    }
                }
            }

            return listaVentas;
        }

        public List<ClsVentasEmpleado> ObtenerReporteEmpleado()
        {
            List<ClsVentasEmpleado> reporteEmpleados = new List<ClsVentasEmpleado>();
            

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            using (MySqlConnection conexion = new MySqlConnection(strConexion))
            {
                conexion.Open();
                string strConsulta = "SELECT * FROM reporte_empleado"; 

                using (MySqlCommand comando = new MySqlCommand(strConsulta, conexion))
                {
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClsVentasEmpleado reporte = new ClsVentasEmpleado
                            {
                                Empleado = reader.GetString("Empleado"),
                                Total = reader.GetDecimal("Total"),
                                CantVentas = reader.GetInt32("CANT_VENTAS")
                            };
                            reporteEmpleados.Add(reporte);
                            
                        }
                    }
                }
            }

            return reporteEmpleados;
        }


    }
}
