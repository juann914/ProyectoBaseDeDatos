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
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {

        }
        public String idCliente()
        {
            return textNombre.Text;
        }

        private void butAgreC_Click(object sender, EventArgs e)
        {
            if (textNombre.Text.Equals("") || textApellidos.Text.Equals("") || textCorreo.Text.Equals("") ||
                textRFC.Text.Equals(""))
            {
                MessageBox.Show("Debes de ingresar todos los campos");
            }
            else
            {
                clsCliente clsCliente = new clsCliente();



                clsCliente.nombre = textNombre.Text;
                clsCliente.apellidos = textApellidos.Text;
                clsCliente.rfc = textRFC.Text;
                clsCliente.correo = textCorreo.Text;

                daoClientes daoClientes = new daoClientes();
                daoClientes.insertarCliente(clsCliente);

                textApellidos.Text = "";
                textNombre.Text = "";
                textCorreo.Text = "";
                textRFC.Text = "";



            }
        }
    }
}
