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

                dataGridProductos.Rows.Clear();

                dataGridProductos.Rows.Add(product.idProducto,product.codigoBarra,product.nombre,product.precio
                    ,product.marca,product.descripcion,product.cantidad);

               
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
            if (txtDes.Text.Equals("") && txtNombre.Text.Equals("") && txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Debes de ingresar por lo menos un campo");
            }
            else
            {


                daoProductos daoProductos = new daoProductos();

                clsProductos productos = daoProductos.obtenerCodigo(txtCodigo.Text);

                if (txtNombre.Text.Length>0)
                {
                    productos.nombre = txtNombre.Text;
                }
                
                if (txtPrecio.Text.Length>0)
                {
                    productos.precio = double.Parse(txtPrecio.Text);
                }

                if (txtDes.Text.Length > 0)
                {
                    productos.descripcion = txtDes.Text;
                }
                

                daoProductos.editarProducto(productos);
                MessageBox.Show("Producto editado correctamente");

                dataGridProductos.Rows.Clear();
                dataGridProductos.Rows.Add(productos.idProducto, productos.codigoBarra, productos.nombre, productos.precio
                       , productos.marca, productos.descripcion, productos.cantidad);

                gpProducto.Visible = false;
                gpCode.Visible = true;
                txtCodigo.Text = "";
                txtDes.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
            }
        }

        }
}
