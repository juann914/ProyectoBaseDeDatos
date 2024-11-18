using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databasesproyect.Vistas
{
    public partial class ClietneInsertar : Form
    {
        public ClietneInsertar()
        {
            InitializeComponent();
        }

        private void ClietneInsertar_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

            if (txtRfc.Text.Equals("") || txtApellido.Text.Equals("") || txtCorreo.Text.Equals("") || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Faltan campos por rellenar");
            }
            else
            {
                daoClientes daoClientes = new daoClientes();

                clsCliente cliente = new clsCliente();

                cliente.nombre = txtNombre.Text;
                cliente.apellidos = txtApellido.Text;
                cliente.correo = txtCorreo.Text;
                cliente.rfc = txtRfc.Text;

                daoClientes.insertarCliente(cliente);

                this.Close();
            }
        }
    }
}
