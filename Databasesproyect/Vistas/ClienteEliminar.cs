using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Tls.Crypto;

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
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debes primero introducir el id del cliente");
            }
            else
            {
                daoClientes daoclientes= new daoClientes();
                clsCliente cliente = daoclientes.obenterCliente(txtCodigo.Text);

                if (cliente == null)
                {
                    MessageBox.Show("No se encontro el cliente");
                }
                else
                {
                    dataGridClientes.Rows.Clear();
                    dataGridClientes.Rows.Add(cliente.idCliente,cliente.nombre,cliente.apellidos,cliente.correo,cliente.rfc);


                    gpEliminar.Visible = true;
                    gpCodigo.Visible = false;


                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            daoClientes daoClientes= new daoClientes(); 
            daoClientes.borrarCliente(txtCodigo.Text);

            MessageBox.Show("cliente eliminado correctamente");
            txtCodigo.Text = "";
            gpEliminar.Visible = false;
            gpCodigo.Visible = true;
            dataGridClientes.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridClientes.Rows.Clear();
            gpEliminar.Visible = false;
            gpCodigo.Visible = true;
            txtCodigo.Text = "";
        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
