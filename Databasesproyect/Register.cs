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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsEmpleados emp = new clsEmpleados();

            emp.clave=txtContraseña.Text;
            emp.username=txtUserName.Text;
            emp.nombre=txtNombre.Text;
            emp.apellido=txtApellidos.Text;
            emp.telefono=txtTeléfono.Text;
            emp.curp=txtCURP.Text;
            emp.edad=int.Parse(txtEdad.Text);

            DaoEmpleados daoEmp = new DaoEmpleados();
            daoEmp.insertarEmpleado(emp);
            MessageBox.Show("Empleado insertado correctamente");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login FormReg = new Login();
            FormReg.Show();
            this.Hide();
        }
    }
}
