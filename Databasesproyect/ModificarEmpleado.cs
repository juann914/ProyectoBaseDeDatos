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
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsEmpleados emp = new clsEmpleados();

            emp.idEmpleado = int.Parse(txtId.Text);
            emp.clave = txtContraseña.Text;
            emp.username = txtUserName.Text;
            emp.nombre = txtNombre.Text;
            emp.apellido = txtApellidos.Text;
            emp.telefono = txtTeléfono.Text;
            emp.curp = txtCURP.Text;
            emp.edad = int.Parse(txtEdad.Text);

            DaoEmpleados daoEmp = new DaoEmpleados();
            daoEmp.modificarEmpleado(emp);
            MessageBox.Show("Empleado modificado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuEmpleados menu = new MenuEmpleados();
            menu.Show();
            this.Hide();
        }
    }
}
