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

    }
    }
}
