using Databasesproyect.Clases;
using Databasesproyect.Daos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databasesproyect.Vistas
{
    public partial class ReporteTrimestre : Form
    {
        public ReporteTrimestre()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CargarVentasPorTrimestre(int anio)
        {
            try
            {
                
                // Instanciar la clase DaoReportes para acceder al método
                DaoReportes dao = new DaoReportes();

                // Obtener los datos
                List<ClsVentasPorTrimestre> ventas = dao.ObtenerVentasPorTrimestre(int.Parse(txtAño.Text));

                // Llenar el DataGridView
                dgvVentasPorTrimestre.DataSource = null; // Limpia el DataGridView
                dgvVentasPorTrimestre.DataSource = ventas; // Asigna la lista de ventas como fuente de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarVentasPorTrimestre(2024);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_de_reportes menu = new Menu_de_reportes();
            menu.Show();
            this.Hide();
        }
    }
}
