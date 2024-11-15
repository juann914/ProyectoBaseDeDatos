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
    public partial class ProductoEliminar : Form
    {
        public ProductoEliminar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos productos = new Productos();
            productos.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debes primero introducir el codigo del producto");
            }
            else
            {
                daoProductos productos = new daoProductos();
                clsProductos product = productos.obtenerCodigo(txtCodigo.Text);

                if (product == null)
                {
                    MessageBox.Show("No se encontro el producto");
                }
                else
                {
                    dataGridProductos.Rows.Clear();
                    dataGridProductos.Rows.Add(product.idProducto, product.codigoBarra, product.nombre, product.precio,
                        product.marca, product.descripcion, product.cantidad);


                    gpEliminar.Visible = true;
                    gpCodigo.Visible = false;
                 

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            daoProductos productos=new daoProductos();
            productos.borrarProducto(txtCodigo.Text);

            MessageBox.Show("Producto eliminado correctamente");
            txtCodigo.Text = "";
            gpEliminar.Visible= false;
            gpCodigo.Visible= true;
            dataGridProductos.Rows.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridProductos.Rows.Clear();
            gpEliminar.Visible=false;
            gpCodigo.Visible=true;
            txtCodigo.Text = "";
        }
    }
}
