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
    public partial class ReporteMes : Form
    {
        public ReporteMes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DateTime.Parse(txtFechaInicio.Text);
            DateTime fechaFin = DateTime.Parse(txtFechaFinal.Text);

            
            DaoReportes dao = new DaoReportes();

            
            List<ClsVentasPorMes> ventas = dao.ObtenerVentasPorMes(fechaInicio, fechaFin);

            
            dgvVentasMensuales.DataSource = ventas;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_de_reportes menu = new Menu_de_reportes();
            menu.Show();
            this.Hide();
        }
    }
}
