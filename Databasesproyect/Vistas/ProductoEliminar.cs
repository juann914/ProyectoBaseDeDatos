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
            daoProductos daoProductos = new daoProductos();
            clsProductos p=daoProductos.obtenerCodigo(txtCodigo.Text);

            if (p==null)
            {
                MessageBox.Show("No se ha encontrado el producto");
            }
            else
            {
                ConfirmarEliminarP c=new ConfirmarEliminarP(p.codigoBarra);
                c.Show();
                this.Hide();
                c.lnbPro.Text = "Esta a punto de eliminar el producto " + p.nombre + "\n                ¿Estas seguro?";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
