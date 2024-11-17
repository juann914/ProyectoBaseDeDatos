using Databasesproyect.Clases;
using Databasesproyect.Vistas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databasesproyect
{
    public partial class Ventas : Form
    {
        public int idEmpleado;
        
        public Ventas(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            DaoVenta daoVenta = new DaoVenta();
            
            decimal a = decimal.Parse(teDes.Text);
            daoVenta.AgregarProducto(textCodigo.Text,dataVentas);
            
            textCodigo.Clear();
            laSubtotal.Text = "$ " + daoVenta.CalcularSubtotal();
            laDesc.Text = "$ " + daoVenta.Descuento(daoVenta.CalcularSubtotal(), a);
            laIVA.Text = "$ " + daoVenta.Iva(daoVenta.CalcularSubtotal());
            laTotal.Text = "$ " + daoVenta.Total(daoVenta.CalcularSubtotal(), daoVenta.Iva(daoVenta.CalcularSubtotal()), daoVenta.Descuento(daoVenta.CalcularSubtotal(), a));
        }
        

        private void Ventas_Load(object sender, EventArgs e)
        {
            

        }

        private void butBorrar_Click(object sender, EventArgs e)
        {
            if (dataVentas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataVentas.SelectedRows)
                {
                    dataVentas.Rows.Remove(row);
                }

                MessageBox.Show("Producto eliminado de la tabla.");
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar de la tabla.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataVentas.DataSource != null)
            {

                dataVentas.DataSource = null;
            }
            else
            {

                dataVentas.Rows.Clear();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void laSubtotal_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DaoVenta daoVenta = new DaoVenta();
            Register register = new Register();
            
            ProductosInsertar productosInsertar = new ProductosInsertar();
            String n = register.nombre();
            String m = productosInsertar.nombre();
            
            decimal a = decimal.Parse(teDes.Text);
            clsVentas venta = new clsVentas {
                subtotal = daoVenta.CalcularSubtotal(),
                descuento = daoVenta.Descuento(daoVenta.CalcularSubtotal(), a),
                iva = daoVenta.Iva(daoVenta.CalcularSubtotal()),
                total = daoVenta.Total(daoVenta.CalcularSubtotal(), daoVenta.Iva(daoVenta.CalcularSubtotal()), daoVenta.Descuento(daoVenta.CalcularSubtotal(), a)),
                idEmpleado = idEmpleado,
                idCliente = daoVenta.idCliente(textNombre.Text)



            };
            List<clsDetallesVenta> detalles = new List<clsDetallesVenta>();
            foreach (DataGridViewRow row in dataVentas.Rows)
            {
                if (row.Cells["codigoBarra"].Value != null) // Evitar filas vacías
                {
                    detalles.Add(new clsDetallesVenta
                    {
                        idProducto = daoVenta.idProducto(m),
                        cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                        precio = Convert.ToDecimal(row.Cells["precio"].Value),
                        subtotal = daoVenta.CalcularSubtotal(),
                        descuento = daoVenta.Descuento(daoVenta.CalcularSubtotal(), a),
                        total = daoVenta.Total(daoVenta.CalcularSubtotal(), daoVenta.Iva(daoVenta.CalcularSubtotal()), daoVenta.Descuento(daoVenta.CalcularSubtotal(), a)),

                    });
                }
            }


            daoVenta.insertarVenta(venta, detalles);
        }

        
            
        

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                if (textNombre.Text.Equals("") || textApellidos.Text.Equals("") || textCorreo.Text.Equals("") ||
                    textRFC.Text.Equals(""))
                {
                    MessageBox.Show("Debes de ingresar todos los campos");
                }
                else
                {
                    clsCliente clsCliente = new clsCliente();



                    clsCliente.nombre = textNombre.Text;
                    clsCliente.apellidos = textApellidos.Text;
                    clsCliente.rfc = textRFC.Text;
                    clsCliente.correo = textCorreo.Text;

                    daoClientes daoClientes = new daoClientes();
                    daoClientes.insertarCliente(clsCliente);

                    textApellidos.Text = "";
                    textNombre.Text = "";
                    textCorreo.Text = "";
                    textRFC.Text = "";



                }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(idEmpleado);
            menu.ShowDialog();
            this.Close();
        }
    }
}