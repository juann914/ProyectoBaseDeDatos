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
            Ventas ventas= new Ventas(idEmpleado);
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
    }
}
