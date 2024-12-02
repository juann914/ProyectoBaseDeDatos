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
            if (txtCodigo.Text.Equals("") || txtMarca.Text.Equals("")  ||
                txtPrecio.Text.Equals("") || txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Faltan campos por rellenar");

            }
            else
            {

                clsProductos product = new clsProductos();
                product.nombre = txtNombre.Text;
                product.codigoBarra = txtCodigo.Text;
                product.precio = double.Parse(txtPrecio.Text);
                product.marca = txtMarca.Text;
                product.descripcion = txtDes.Text;
                product.cantidad=int.Parse(txtCantidad.Text);

                daoProductos daoProductos = new daoProductos();
                daoProductos.insertarProductos(product);

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtMarca.Text = "";
                txtPrecio.Text = "";
                txtDes.Text = "";
                txtCantidad.Text = "";
                MessageBox.Show("Producto insertado correctamente");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Productos productos = new Productos();
            productos.Show();
        }

        private void ProductosInsertar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public String nombre()
            { return txtNombre.Text; }
    }
}
