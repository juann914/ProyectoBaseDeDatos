﻿using System;
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
        public double subdesc;
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
            double des = double.Parse(teDes.Text);
            laDesc.Text = "$" + (des / 100);
            if (des > 0)
            {

                laSubtotal.Text = "$" + (subtotal-((des / 100) * subtotal));
                subdesc = (subtotal - ((des / 100) * subtotal));
            }
            else
            {
                laSubtotal.Text = "$" + subtotal;
                subdesc = (subtotal - ((des / 100) * subtotal));
            }
            laIVA.Text ="$"+(subdesc*0.16);
            laTotal.Text = "$" + ((subdesc) + (subdesc * 0.16));

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            daoClientes daoclientes=new daoClientes();

            clsCliente clsCliente = daoclientes.obenterCliente(txtId.Text);

            if(clsCliente == null)
            {
                MessageBox.Show("No se encontro el cliente");
            }
            else
            {
                MessageBox.Show("Se encontro el cliente");
                txtId.Text = "";
            }
        }
    }
}