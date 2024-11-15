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
    }
}
