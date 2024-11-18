using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Databasesproyect.Vistas;

namespace Databasesproyect
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ClienteEliminar cliente = new ClienteEliminar();
            cliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ClienteModificar cliente = new ClienteModificar();
            cliente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClienteSolicitarDatos cliente=new ClienteSolicitarDatos();
            cliente.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu .Show();
            this.Close();
        }
    }
}
