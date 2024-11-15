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
    public partial class ClienteSolicitarDatos : Form
    {
        public ClienteSolicitarDatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daoClientes daoClientes = new daoClientes();
            clsCliente[] clientes = daoClientes.obtenerTodos();

            dataGridUser.Rows.Clear();


            if (clientes != null)
            {
                foreach (clsCliente cliente in clientes)
                {
                    dataGridUser.Rows.Add(
                        cliente.idCliente,
                        cliente.nombre,
                        cliente.apellidos,
                        cliente.correo,
                        cliente.rfc
                    );
                }
            }
        }

        private void btnAcpetar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debes primero introducir el codigo del cliente a buscar");
            }
            else
            {
                daoClientes daoClientes = new daoClientes();
                clsCliente cliente = daoClientes.obenterCliente(txtCodigo.Text);

                if (cliente == null)
                {
                    MessageBox.Show("No se encontro el cliente");
                }
                else
                {
                    dataGridUser.Rows.Clear();
                    dataGridUser.Rows.Add(cliente.idCliente, cliente.nombre, cliente.apellidos, cliente.correo, cliente.rfc);

                    gpCode.Visible = true;


                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.Show();
        }
    }
}
