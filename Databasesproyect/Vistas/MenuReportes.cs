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
    public partial class Menu_de_reportes : Form
    {
        public Menu_de_reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteMes reportes = new ReporteMes();
            reportes.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteEmpleado reportes = new ReporteEmpleado();
            reportes.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReporteTrimestre reportes = new ReporteTrimestre();
            reportes.Show();
            this.Hide();
        }
    }
}
