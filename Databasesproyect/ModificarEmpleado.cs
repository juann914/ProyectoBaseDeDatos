using ProyectoDeBaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databasesproyect
{
    public partial class ModificarEmpleado : Form
    {
        public ModificarEmpleado()
        {
            
            InitializeComponent();
        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
            DaoEmpleados dao = new DaoEmpleados();
            
            dataGridView1.DataSource = dao.cargarEmpleados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
