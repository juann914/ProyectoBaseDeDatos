using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Win32;
using ProyectoDeBaseDeDatos;

namespace Databasesproyect
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DaoEmpleados daoEmpleados = new DaoEmpleados();

            string user=txtUserame.Text;
            string password = txtPassword.Text;

            bool bandera=daoEmpleados.verificar(user, password);

            if (bandera == true)
            {
                //llamar otro forms
                this.Hide();
                clsEmpleados clsEmpleados = daoEmpleados.consultarEmpleadoPorUserName(txtUserame.Text);
                Menu menu =new Menu (clsEmpleados.idEmpleado);
                menu.Show();

                

            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registroForm = new Register();
            registroForm.FormAnterior = this; // Guarda la referencia al formulario actual (Ventas)
            registroForm.Show(); // Muestra el formulario Registro
            this.Hide(); // Oculta el formulario Ventas
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
