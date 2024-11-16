using Databasesproyect.Clases;
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
        
        public Ventas()
        {
            InitializeComponent();
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
            String codigoBarras =textCodigo.Text;
            decimal a = decimal.Parse(teDes.Text);          
            daoVenta.AgregarProducto(codigoBarras);
            textCodigo.Clear();
            laSubtotal.Text = "$ " + daoVenta.CalcularSubtotal();
            laDesc.Text="$ " + daoVenta.Descuento(daoVenta.CalcularSubtotal(),a);
            laIVA.Text="$ "+ daoVenta.Iva(daoVenta.CalcularSubtotal());
            laTotal.Text = "$ " + daoVenta.Total(daoVenta.CalcularSubtotal(), daoVenta.Iva(daoVenta.CalcularSubtotal()), daoVenta.Descuento(daoVenta.CalcularSubtotal(), a));
        }
       

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataVentas.Columns.Add("codigoBarra", "Código de Barra");
            dataVentas.Columns.Add("nombre", "Nombre");
            dataVentas.Columns.Add("marca", "Marca");
            dataVentas.Columns.Add("precio", "Precio Unitario");
            dataVentas.Columns.Add("cantidad", "Cantidad");
            
        }

        private void butBorrar_Click(object sender, EventArgs e)
        {
            if (dataVentas.SelectedRows.Count > 0) 
            {
                foreach (DataGridViewRow row in dataVentas.SelectedRows)
                {
                    dataVentas.Rows.Remove(row);
                }

                MessageBox.Show("Producto eliminado de la tabla (solo visualización).");
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
            decimal a = decimal.Parse(teDes.Text);
            clsVentas venta = new clsVentas();
            {
                venta.subtotal = daoVenta.CalcularSubtotal(),
                venta.descuento = daoVenta.Descuento((daoVenta.CalcularSubtotal(), a),
                venta.iva=daoVenta.Iva(daoVenta.CalcularSubtotal()),
                venta.total = daoVenta.Total(daoVenta.CalcularSubtotal(), daoVenta.Iva(daoVenta.CalcularSubtotal()), daoVenta.Descuento(daoVenta.CalcularSubtotal(), a)),
                
            };



            daoVenta.insertarVenta(venta,);
        }
    }
}
