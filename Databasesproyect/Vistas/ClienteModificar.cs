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
    public partial class ClienteModificar : Form
    {
        public ClienteModificar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            daoClientes daoClientes = new daoClientes();

            clsCliente cliente = daoClientes.obenterCliente(txtId.Text);

            if (cliente == null)
            {
                MessageBox.Show("No se encontro el cliente");
            }
            else
            {
                gpId.Visible = false;
                gpCliente.Visible = true;
                txtNombre.Text=cliente.nombre;
                txtApellidos.Text=cliente.apellidos;
                txtCorreo.Text=cliente.correo;
                lblNombre.Text="Cliente "+ cliente.nombre;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            daoClientes daoClientes = new daoClientes();

            clsCliente cliente = daoClientes.obenterCliente(txtId.Text);

            cliente.nombre = txtNombre.Text;
            cliente.apellidos = txtApellidos.Text;
            cliente.correo = txtCorreo.Text;

            daoClientes.editarCliente(cliente);
            MessageBox.Show("Cliente editado");
            gpCliente.Visible=false;
            gpId.Visible=true;
            txtId.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes   = new Clientes();
            clientes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gpCliente.Visible = false;
            gpId.Visible = true;
            txtId.Text = "";
        }
    }
}
