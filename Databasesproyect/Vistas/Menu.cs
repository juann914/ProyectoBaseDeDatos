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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas ventas= new Ventas();
            ventas.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos productos= new Productos();
            productos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuEmpleados productos = new MenuEmpleados();
            productos.Show();
            this.Hide();
        }
    }
}