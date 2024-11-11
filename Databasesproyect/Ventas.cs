using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databasesproyect
{
    public partial class Ventas : Form
    {
        
        public Ventas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string strConexion = "server=localhost; User ID=root; password=root; Database=ventas2; port=3306;";
        string query = "SELECT Clave,Marca,Descripción,Precio FROM productos";
        private void butAgregar_Click(object sender, EventArgs e)
        {
            VenAgregar venAgregar = new VenAgregar();
            venAgregar.ShowDialog();
            String clave = venAgregar.Clave();
            BuscarProductoPorCodigo(clave);
           
        }
        private void BuscarProductoPorCodigo(string codigoBarras)
        {
            using (SqlConnection connection = new SqlConnection(strConexion))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@codigoBarras", codigoBarras);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataVentas.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el producto: " + ex.Message);
                }
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void butBorrar_Click(object sender, EventArgs e)
        {
            if (dataVentas.SelectedRows.Count > 0) 
            {
                foreach (DataGridViewRow row in dataVentas.SelectedRows)
                {
                    dataVentas.Rows.Remove(row);
                }

                MessageBox.Show("Producto eliminado de la tabla (solo visualización).");
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar de la tabla.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataVentas.DataSource != null)
            {
                
                dataVentas.DataSource = null;
            }
            else
            {
                
                dataVentas.Rows.Clear();
            }
        }
    }
}
