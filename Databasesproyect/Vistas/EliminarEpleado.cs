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
    public partial class EliminarEpleado : Form
    {
        public EliminarEpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsEmpleados emp = new clsEmpleados();

            emp.idEmpleado = int.Parse(txtId.Text);
            

            DaoEmpleados daoEmp = new DaoEmpleados();
            daoEmp.eliminarEmpleado(emp);
            MessageBox.Show("Empleado Eliminado correctamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEmpleados menu = new MenuEmpleados();
            menu.Show();
            this.Hide();
        }
    }
}
