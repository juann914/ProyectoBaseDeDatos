﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Databasesproyect.Vistas;

namespace Databasesproyect
{
    public partial class Menu : Form
    {
        public int idEmpleado;
        public Menu(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
        }

        public Menu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas2 ventas= new Ventas2(idEmpleado);
            ventas.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos productos= new Productos();
            productos.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuEmpleados productos = new MenuEmpleados();
            productos.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ventas2 ventas = new Ventas2(idEmpleado);
            ventas.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clientes c= new Clientes();
            c.Show();
            this.Close();
                        
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Ventas2 ventas = new Ventas2(idEmpleado);
            ventas.Show();
        }
    }
}
