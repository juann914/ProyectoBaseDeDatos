﻿using Microsoft.Win32;
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
    public partial class MenuEmpleados : Form
    {
        public MenuEmpleados()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register registroForm = new Register();
            registroForm.FormAnterior = this; // Guarda la referencia al formulario actual (Ventas)
            registroForm.Show(); // Muestra el formulario Registro
            this.Hide(); // Oculta el formulario Ventas
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarEmpleado menu = new ModificarEmpleado();
            menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarEpleado menu = new EliminarEpleado();
            menu.Show();
            this.Hide();
        }
    }
}
