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
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debes primero introducir el codigo del producto a buscar");
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
                    dataGridProductos.Rows.Add(product.idProducto,product.codigoBarra,product.nombre,product.precio,
                        product.marca,product.descripcion,product.cantidad);
                    
                    gpProducto.Visible = true;


                }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gpProducto_Enter(object sender, EventArgs e)
        {

        }

        private void gpCode_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            daoProductos daoProductos = new daoProductos();
            clsProductos[] products = daoProductos.obtenerTodos();

            dataGridProductos.Rows.Clear();

            
            if (products != null)
            {
                foreach (clsProductos product in products)
                {
                    dataGridProductos.Rows.Add(
                        product.idProducto,
                        product.codigoBarra,
                        product.nombre,
                        product.precio,
                        product.marca,
                        product.descripcion,
                        product.cantidad
                    );
                }
            }

        }
    }
}
