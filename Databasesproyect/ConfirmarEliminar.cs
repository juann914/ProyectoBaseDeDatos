﻿using System;
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
    public partial class ConfirmarEliminar : Form
    {

        public string PrCode { get; set; }

        public ConfirmarEliminar(string PrCode)
        {


            InitializeComponent();
            this.PrCode = PrCode;
        }

        private void ConfirmarEliminar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            EliminarProducto producto = new EliminarProducto();
            producto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daoProductos productos  = new daoProductos();
            productos.borrarProducto(this.PrCode);
            MessageBox.Show("El producto se ha eliminado correctamente");
             this.Close();
            EliminarProducto producto = new EliminarProducto();
            producto.Show();
        }
    }
}
