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
using ProyectoDeBaseDeDatos;
using Databasesproyect.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.ComponentModel;

namespace Databasesproyect
{
   
    internal class DaoVenta
    {
        private List<clsProductos> productosEnVenta = new List<clsProductos>();



        public DataTable obtenerProducto(string codigoBarra)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();

            string str = "select Idproducto,CodigoBarra,Nombre,Precio ,Marca,Descripcion from productos where codigoBarra=@codigoBarra;";


            MySqlCommand comando = new MySqlCommand(str, conexion);
            comando.Parameters.AddWithValue("@codigoBarra", codigoBarra);

         

            DataTable dataTable = new DataTable();
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando))
            {
                dataAdapter.Fill(dataTable);
            }
            conexion.Close();
            return dataTable;
            
        }
        public void AgregarProducto(string codigoBarras, DataGridView dataGridView)
        {

            var productoExistente = productosEnVenta.FirstOrDefault(p => p.codigoBarra == codigoBarras);

            if (productoExistente != null)
            {
                productoExistente.cantidad++; // Incrementar la cantidad
            }
            else
            {
                DataTable productoTable = obtenerProducto(codigoBarras);

                if (productoTable.Rows.Count > 0)
                {
                    DataRow row = productoTable.Rows[0];
                    clsProductos nuevoProducto = new clsProductos
                    {
                        idProducto = Convert.ToInt32(row["Idproducto"]),
                        codigoBarra = row["CodigoBarra"].ToString(),
                        nombre = row["Nombre"].ToString(),
                        marca = row["Marca"].ToString(),
                        precio = Convert.ToDouble(row["Precio"]),
                        descripcion = row["Descripcion"].ToString(),
                        cantidad = 1 // Cantidad inicial
                    };

                    productosEnVenta.Add(nuevoProducto);
                }
                else
                {
                    throw new Exception("Producto no encontrado");
                }
            }

            // Actualiza el DataGridView
            CargarDatos(dataGridView);
        }
        public void CargarDatos(DataGridView dataGridView)
        {
            dataGridView.DataSource = null; 
            dataGridView.DataSource = productosEnVenta; 
            dataGridView.Refresh(); 
        }

        public decimal CalcularSubtotal()
        {
            decimal subtotal = 0;

            
            foreach (var productos in productosEnVenta)
            {
                subtotal += (decimal) (productos.precio*productos.cantidad);
            }

            return subtotal;
        }
        public decimal Descuento(decimal subtotal, decimal porcentaje)
        {
            decimal descuento = subtotal * (porcentaje / 100);
            
            return descuento;
        }
        public decimal Iva(decimal subtotal)
        {
            decimal iva = subtotal * (16 / 100);

            return iva;
        }
        public decimal Total(decimal subtotal,decimal iva,decimal descuento)
        {
            decimal total = subtotal + iva-descuento;
            return total;
        }
        public void insertarVenta(clsVentas venta, List<clsDetallesVenta> detalles)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            MySqlConnection conexion = new MySqlConnection(strConexion);
            conexion.Open();

            string strInsert = "insert into ventas values(@idventa,@descuento,@Iva,@subtotal,@total,@idEmpleado,@idCliente);";
            MySqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                MySqlCommand comando = new MySqlCommand(strInsert, conexion, transaccion);


                comando.Parameters.AddWithValue("@idventa", venta.idventa);
                comando.Parameters.AddWithValue("@descuento", venta.descuento);
                comando.Parameters.AddWithValue("@Iva", venta.iva);
                comando.Parameters.AddWithValue("@subtotal", venta.subtotal);
                comando.Parameters.AddWithValue("@total", venta.total);
                comando.Parameters.AddWithValue("@idEmpleado", venta.idEmpleado);
                comando.Parameters.AddWithValue("@idCliente", venta.idCliente);


                comando.ExecuteNonQuery();
                long idventa = comando.LastInsertedId;
                string strVenta = "insert into detallesDeVentas values(@idDetalle,@idventa,@idProducto,@cantidad,@precio,@descuento,@Iva,@subtotal,@total);";
                foreach (var detalle in detalles)
                {
                    MySqlCommand comandoVend = new MySqlCommand(strVenta, conexion, transaccion);
                    comandoVend.Parameters.AddWithValue("@idDetalle", idventa);
                    comandoVend.Parameters.AddWithValue("@idventa", detalle.idventa);
                    comandoVend.Parameters.AddWithValue("@idProducto", detalle.idProducto);
                    comandoVend.Parameters.AddWithValue("@Iva", detalle.iva);
                    comandoVend.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                    comandoVend.Parameters.AddWithValue("@precio", detalle.precio);
                    comandoVend.Parameters.AddWithValue("@descuento", detalle.descuento);
                    comandoVend.Parameters.AddWithValue("@subtotal", detalle.subtotal);
                    comandoVend.Parameters.AddWithValue("@total", detalle.total);
                    comandoVend.ExecuteNonQuery();

                }
                transaccion.Commit();
                MessageBox.Show("Venta realizada ");
                conexion.Close();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                conexion.Close();
                Console.WriteLine($"Error al guardar la venta: {ex.Message}");
                MessageBox.Show("Error en la Venta  ");
            }


        }
        public int idEmpleado(String nombre)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            using (MySqlConnection conexion = new MySqlConnection(strConexion))
            {
                conexion.Open();
                string strConsulta = "SELECT idEmpleado FROM empleados WHERE nombre = @nombre";
                using (MySqlCommand comando = new MySqlCommand(strConsulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        int s = 0;
                        clsEmpleados emp = new clsEmpleados();
                        if (reader.Read())
                        {
                            emp.idEmpleado = reader.GetInt32("idEmpleado");
                            s = emp.idEmpleado;
                        }
                        return s;
                    }
                }
            }

        }
        public int idProducto(String nombre)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            using (MySqlConnection conexion = new MySqlConnection(strConexion))
            {
                conexion.Open();
                string strConsulta = "SELECT idProducto FROM productos WHERE nombre = @nombre";
                using (MySqlCommand comando = new MySqlCommand(strConsulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        int s = 0;
                        clsProductos emp = new clsProductos();
                        if (reader.Read())
                        {
                            emp.idProducto = reader.GetInt32("idEmpleado");
                            s = emp.idProducto;
                        }
                        return s;
                    }
                }
            }

        }
        public int idCliente(String nombre)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            using (MySqlConnection conexion = new MySqlConnection(strConexion))
            {
                conexion.Open();
                string strConsulta = "SELECT idCliente FROM clientes WHERE nombre = @nombre";
                using (MySqlCommand comando = new MySqlCommand(strConsulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        int s = 0;
                        clsCliente emp = new clsCliente();
                        if (reader.Read())
                        {
                            emp.idCliente = reader.GetInt32("idCliente");
                            s = emp.idCliente;
                        }
                        return s;
                    }
                }
            }

        }

    }
    }

