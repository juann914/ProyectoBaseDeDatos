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
using Databasesproyect.Vistas;

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
                productoExistente.cantidad++; 
            }
            else
            {
                DataTable productoTable = obtenerProducto(codigoBarras);

                if (productoTable.Rows.Count > 0)
                {
                    int contador = 0;
                    DataRow row = productoTable.Rows[contador];
                    clsProductos nuevoProducto = new clsProductos
                    {
                        idProducto = Convert.ToInt32(row["Idproducto"]),
                        codigoBarra = row["CodigoBarra"].ToString(),
                        nombre = row["Nombre"].ToString(),
                        marca = row["Marca"].ToString(),
                        precio = Convert.ToDouble(row["Precio"]),
                        descripcion = row["Descripcion"].ToString(),
                        cantidad = 1 
                        
                    };
                    contador++;
                    productosEnVenta.Add(nuevoProducto);
                    
                }
                else
                {
                    
                    MessageBox.Show("Producto no encontrado.");
                }
            }

            
            CargarDatos(dataGridView);
        }
        public void CargarDatos(DataGridView dataGridView)
        {
            
            dataGridView.DataSource = productosEnVenta; 
           
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
            decimal resul = subtotal * (16 / 100);

            return resul;
        }
        public decimal Total(decimal subtotal,decimal iva,decimal descuento)
        {
            decimal total = subtotal + iva-descuento;
            return total;
        }

        public void insertarDetallesVentas(clsDetallesVenta detalles)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();

            string strInsert = "insert into detallesDeVentas values (null,@idProducto,@idventa,@cantidad,@precio,@descuento,@Iva,@subtotal,@total)";


            MySqlCommand comando = conexion.CreateCommand();
            using (MySqlTransaction transaccion = conexion.BeginTransaction())
            {
                try
                {

                    comando.Parameters.AddWithValue("@idProducto", detalles.idProducto);
                    comando.Parameters.AddWithValue("@idventa", detalles.idventa);
                    comando.Parameters.AddWithValue("@cantidad", detalles.cantidad);
                    comando.Parameters.AddWithValue("@precio", detalles.precio);
                    comando.Parameters.AddWithValue("@Iva", detalles.iva);
                    comando.Parameters.AddWithValue("@subtotal", detalles.subtotal);
                    comando.Parameters.AddWithValue("@total", detalles.total);
                    comando.Parameters.AddWithValue("@descuento", detalles.descuento);



                    comando.CommandText = strInsert;

                    transaccion.Commit();
                    comando.ExecuteNonQuery();
                   

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    // Revertir la transacción en caso de error
                    transaccion.Rollback();
                    MessageBox.Show($"Error al guardar la venta: {ex.Message}");
                }
            }

        }
        public void insertarVenta(clsVentas venta, List<clsDetallesVenta> detalles)
        {

            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
            
            using (MySqlConnection conexion = new MySqlConnection(strConexion))
            {
                conexion.Open();

                using (MySqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        // Insertar la venta sin especificar el idventa (autoincremental)
                        string strInsertVenta = "INSERT INTO ventas VALUES (null,@descuento,@Iva,@subtotal,@total,@idEmpleado,@idCliente,@fechaVenta);";
                        MySqlCommand comandoVenta = new MySqlCommand(strInsertVenta, conexion, transaccion);

                        comandoVenta.Parameters.AddWithValue("@descuento", venta.descuento);
                        comandoVenta.Parameters.AddWithValue("@Iva", venta.iva);
                        comandoVenta.Parameters.AddWithValue("@subtotal", venta.subtotal);
                        comandoVenta.Parameters.AddWithValue("@total", venta.total);
                        comandoVenta.Parameters.AddWithValue("@idEmpleado", venta.idEmpleado);
                        comandoVenta.Parameters.AddWithValue("@idCliente", venta.idCliente);
                        comandoVenta.Parameters.AddWithValue("@fechaVenta", venta.fechaVenta);

                        comandoVenta.ExecuteNonQuery();


                        

                        // Insertar los detalles de la venta
                        

                       
                            



                        for (int i = 0; i < detalles.Count; i++)
                        {
                            string strInsertDetalle = "INSERT INTO detallesDeVentas VALUES (null,@idProducto,@idventa, @cantidad, @precio, @descuento, @Iva, @subtotal, @total);";
                            MySqlCommand comandoDetalle = new MySqlCommand(strInsertDetalle, conexion, transaccion);

                            comandoDetalle.Parameters.AddWithValue("@idProducto", detalles[i].idProducto);
                            comandoDetalle.Parameters.AddWithValue("@idventa", venta.idventa);
                            comandoDetalle.Parameters.AddWithValue("@cantidad", detalles[i].cantidad);
                            comandoDetalle.Parameters.AddWithValue("@precio", detalles[i].precio);
                            comandoDetalle.Parameters.AddWithValue("@descuento", detalles[i].descuento);
                            comandoDetalle.Parameters.AddWithValue("@Iva", detalles[i].iva);
                            comandoDetalle.Parameters.AddWithValue("@subtotal", detalles[i] .subtotal);
                            comandoDetalle.Parameters.AddWithValue("@total", detalles[i].total);
                            
                            comandoDetalle.ExecuteNonQuery();
                        }
                        
                        // Confirmar la transacción
                        transaccion.Commit();
                        MessageBox.Show("Venta realizada exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        // Revertir la transacción en caso de error
                        transaccion.Rollback();
                        MessageBox.Show($"Error al guardar la venta: {ex.Message}");
                    }
                }
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

        public void insertarUnaVenta(clsVentas ventas)
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();

            string strInsert = "insert into ventas values (null,@descuento,@Iva,@subtotal,@total,@idEmpleado,@idCliente,@fechaVenta)";


            MySqlCommand comando = conexion.CreateCommand();

            using (MySqlTransaction transaccion = conexion.BeginTransaction())
            {
                try
                {
                    comando.Parameters.AddWithValue("@descuento", ventas.descuento);


                    comando.Parameters.AddWithValue("@Iva", ventas.iva);

                    comando.Parameters.AddWithValue("@subtotal", ventas.subtotal);

                    comando.Parameters.AddWithValue("@total", ventas.total);

                    comando.Parameters.AddWithValue("@fechaVenta", ventas.fechaVenta);

                    comando.Parameters.AddWithValue("@idEmpleado", ventas.idEmpleado);

                    comando.Parameters.AddWithValue("@idCliente", ventas.idCliente);

                    comando.CommandText = strInsert;

                    transaccion.Commit();
                    comando.ExecuteNonQuery();
                    
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    // Revertir la transacción en caso de error
                    transaccion.Rollback();
                    MessageBox.Show($"Error al guardar la venta: {ex.Message}");
                }

            }
        }

        public int obterUltimoIdVenta()
        {
            string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";


            MySqlConnection conexion = new MySqlConnection(strConexion);

            conexion.Open();

            string str = "select * from ventas";


            MySqlCommand comando = new MySqlCommand(str, conexion);
            

            MySqlDataReader read = comando.ExecuteReader();

            int id = 0;

            while (read.Read())
            {
                
                id = int.Parse(read["idventa"].ToString());
               
               

            }
            conexion.Close();
            comando.Connection.Close();
            return id;
        }

    }
    }

