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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductosInsertar productos = new ProductosInsertar();
            productos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductoEliminar producto = new ProductoEliminar();
            producto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoEditar producto = new ProductoEditar(); 
            producto.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
