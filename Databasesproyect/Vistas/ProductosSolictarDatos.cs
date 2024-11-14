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
    public partial class ProductosSolictarDatos : Form
    {
        public ProductosSolictarDatos()
        {
            InitializeComponent();
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

                txtDes.Text = product.descripcion;
                txtPrecio.Text = product.precio.ToString();
                txtNombre.Text = product.nombre;
                txtCode.Text = product.codigoBarra.ToString();
                txtMarca.Text = product.marca;
                txtCantidad.Text=product.cantidad.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gpProducto.Visible = false;
            gpCode.Visible = true;
            txtCodigo.Text = "";
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
