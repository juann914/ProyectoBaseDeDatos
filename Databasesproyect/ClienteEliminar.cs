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
    public partial class ClienteEliminar : Form
    {
        public ClienteEliminar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            daoClientes daoClientes = new daoClientes();
            clsCliente clsCliente = daoClientes.obenterCliente(txtId.Text);

            if (clsCliente == null)
            {
                MessageBox.Show("No se encontro el cliente");

            }
            else
            {
                gpCliente.Visible = false;
                gpEliminar.Visible = true;
                lblEliminar.Text = "¿Estas seguro de eliminar a " + clsCliente.nombre + " " + clsCliente.apellidos + "?";

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
