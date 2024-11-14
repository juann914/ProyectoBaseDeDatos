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
       
        private void butAgregar_Click(object sender, EventArgs e)
        {
            String codigoBarras =textCodigo.Text;
            DaoVenta daoVenta = new DaoVenta();
            daoVenta.AgregarProducto(codigoBarras);
            textCodigo.Clear();


        }
       

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataVentas.Columns.Add("codigoBarra", "Código de Barra");
            dataVentas.Columns.Add("nombre", "Nombre");
            dataVentas.Columns.Add("marca", "Marca");
            dataVentas.Columns.Add("precio", "Precio Unitario");
            dataVentas.Columns.Add("cantidad", "Cantidad");
            
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
