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
    public partial class ProductoEditar : Form
    {
        public ProductoEditar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcpetar_Click(object sender, EventArgs e)
        {
            daoProductos productos = new daoProductos();
            clsProductos product = productos.obtenerCodigo(txtCodigo.Text);

            if (product == null)
            {
                MessageBox.Show("No se encontro el producto");
            }
            else
            {
                gpCode.Visible = false;
                gpProducto.Visible = true;
                lblProducto.Text = product.nombre;
                txtDes.Text = product.descripcion;
                txtPrecio.Text = product.precio.ToString();
                txtNombre.Text = product.nombre;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gpProducto_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Productos productos = new Productos();
            productos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gpProducto.Visible=false;
            gpCode.Visible = true ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daoProductos daoProductos = new daoProductos();

            clsProductos productos = daoProductos.obtenerCodigo(txtCodigo.Text);

            productos.nombre = txtNombre.Text;
            productos.precio = double.Parse(txtPrecio.Text);
            productos.descripcion = txtDes.Text;

            daoProductos.editarProducto(productos);
            MessageBox.Show("Producto editado correctamente");
            gpProducto.Visible = false;
            gpCode.Visible = true;
            txtCodigo.Text = "";
        }

        }
}
