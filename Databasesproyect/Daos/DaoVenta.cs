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

namespace Databasesproyect
{
   
    internal class DaoVenta
    {
        private List<clsProductos> productosEnVenta;
        
      

        public clsProductos obenterProducto(string codigoBarra)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();

            string str = "select codigoBarra,nombre,precio ,marca,descripcion from productos where codigoBarra=@codigoBarra;";


            MySqlCommand comando = new MySqlCommand(str, conexion);
            comando.Parameters.AddWithValue("@codigoBarra", codigoBarra);

            MySqlDataReader read = comando.ExecuteReader();


            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new clsProductos
                {
                    codigoBarra = row["codigoBarra"].ToString(),
                    nombre = row["nombre"].ToString(),
                    marca = row["marca"].ToString(),
                    precio = (double)Convert.ToDecimal(row["Precio"]),
                    descripcion = row["descripcion"].ToString(),
                    cantidad = 1
                };
            }
            return null;
        }
        public void AgregarProducto(string codigoBarras)
        {
            clsProductos productoExistente = null;

            foreach (var producto in productosEnVenta)
            {
                if (producto.codigoBarra == codigoBarras)
                {
                    productoExistente = producto;
                    break;
                }
            }

            if (productoExistente != null)
            {
                
                productoExistente.cantidad++;
            }
            else
            {
                
                clsProductos nuevoProducto = obenterProducto(codigoBarras);
                if (nuevoProducto != null)
                {
                    productosEnVenta.Add(nuevoProducto);
                }
                else
                {
                    throw new Exception("Producto no encontrado");
                }
            }
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

            string strInsert = "insert into ventas values(@idventa,@descuento,@subtotal,@total,@idEmpleado,@idCliente);";
            MySqlTransaction transaccion = conexion.BeginTransaction();

            try {
                MySqlCommand comando = new MySqlCommand(strInsert, conexion, transaccion);


            comando.Parameters.AddWithValue("@idventa", venta.idventa);
            comando.Parameters.AddWithValue("@descuento", venta.descuento);
            comando.Parameters.AddWithValue("@subtotal", venta.subtotal);
            comando.Parameters.AddWithValue("@total", venta.total);
            comando.Parameters.AddWithValue("@idEmpleado", venta.idEmpleado);
            comando.Parameters.AddWithValue("@idCliente", venta.idCliente);
            

            comando.ExecuteNonQuery();
            long idventa=comando.LastInsertedId;
                string strVenta = "insert into detallesDeVentas values(@idDetalle,@idventa,@idProducto,@cantidad,@precio,@descuento,@subtotal,@total);";
            foreach (var detalle in detalles)
                {
                    MySqlCommand comandoVend = new MySqlCommand(strVenta, conexion, transaccion);
                    comandoVend.Parameters.AddWithValue("@idDetalle", idventa);
                    comandoVend.Parameters.AddWithValue("@idventa", detalle.idventa);
                    comandoVend.Parameters.AddWithValue("@idProducto", detalle.idProducto);
                    comandoVend.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                    comandoVend.Parameters.AddWithValue("@precio", detalle.precio);
                    comandoVend.Parameters.AddWithValue("@descuento", detalle.descuento);
                    comandoVend.Parameters.AddWithValue("@subtotal", detalle.subtotal);
                    comandoVend.Parameters.AddWithValue("@total", detalle.total);
                    comandoVend.ExecuteNonQuery();
                    
                }
            transaccion.Commit();
            Console.WriteLine("Venta y detalles guardados exitosamente.");
            conexion.Close();
            }
            catch (Exception ex)
            {
                // Revertir la transacción si ocurre un error
                transaccion.Rollback();
                conexion.Close();
                Console.WriteLine($"Error al guardar la venta: {ex.Message}");
            }

        }

    }
    }

