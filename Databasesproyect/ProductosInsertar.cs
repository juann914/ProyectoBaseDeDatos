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
    public partial class ProductosInsertar : Form
    {
        public ProductosInsertar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals("") || txtMarca.Text.Equals("") || txtNombre.Text.Equals("") ||
                txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Faltan campos por rellenar");

            }
            
                
            
             clsProductos product= new clsProductos();
             product.nombre=txtNombre.Text;
            product.codigoBarra=txtCodigo.Text;
            product.precio=double.Parse(txtPrecio.Text);
            product.marca=txtMarca.Text;



        }
    }
}
