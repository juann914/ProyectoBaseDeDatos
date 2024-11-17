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
    public partial class Ventas2 : Form
    {
        public double subtotal;
        public Ventas2()
        {
            InitializeComponent();
        }

        private void Ventas2_Load(object sender, EventArgs e)
        {

        }

        private void laTotal_Click(object sender, EventArgs e)
        {

        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            daoProductos daoProductos = new daoProductos();
            clsProductos product = daoProductos.obtenerCodigo(textCodigo.Text);


            dataGridProductos.Rows.Add(product.idProducto, product.codigoBarra, product.nombre, product.precio,
                product.marca, product.descripcion, product.cantidad);

            subtotal += product.precio;

            laSubtotal.Text = "$"+subtotal;

        }
    }
}
