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
    public partial class ReporteEmpleado : Form
    {
        public ReporteEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DaoReportes dao = new DaoReportes();
            List<ClsVentasEmpleado> reporteEmpleados = dao.ObtenerReporteEmpleado();

            dgvReporteEmpleado.DataSource = reporteEmpleados;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_de_reportes menu = new Menu_de_reportes();
            menu.Show();
            this.Hide();
        }
    }
}
