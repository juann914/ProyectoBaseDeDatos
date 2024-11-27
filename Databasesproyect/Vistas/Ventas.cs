using Databasesproyect.Clases;
using Databasesproyect.Vistas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
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
            daoVenta.AgregarProducto(textCodigo.Text, dataVentas);
           
            
            laSubtotal.Text = "$ " + daoVenta.CalcularSubtotal(); ;
            laDesc.Text = "$ " + daoVenta.Descuento(daoVenta.CalcularSubtotal(), a);
            laIva.Text = "$ " + daoVenta.Iva(daoVenta.CalcularSubtotal());
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
                laSubtotal.Text = "$ 0.0"  ;
                laDesc.Text = "$ 0.0";
                laIva.Text = "$ 0.0";
                laTotal.Text = "$ 0.0";

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
                laSubtotal.Text = "$ 0.0";
                laDesc.Text = "$ 0.0";
                laIva.Text = "$ 0.0";
                laTotal.Text = "$ 0.0";
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
            

            string nombreCliente = textNombre.Text;
            decimal descuentoAplicado = decimal.Parse(teDes.Text);

            // Crear objeto venta
            clsVentas venta = new clsVentas
            {
                subtotal = daoVenta.CalcularSubtotal(),
                descuento = daoVenta.Descuento(daoVenta.CalcularSubtotal(), descuentoAplicado),
                iva = daoVenta.Iva(daoVenta.CalcularSubtotal()),
                total = daoVenta.Total(daoVenta.CalcularSubtotal(),
                                       daoVenta.Iva(daoVenta.CalcularSubtotal()),
                                       daoVenta.Descuento(daoVenta.CalcularSubtotal(), descuentoAplicado)),
                idEmpleado = idEmpleado,
                idCliente = daoVenta.idCliente(nombreCliente)
            };

            // Crear lista de detalles de venta
            clsDetallesVenta clsDetalles = new clsDetallesVenta();

            foreach (DataGridViewRow row in dataVentas.Rows)
            {
                if (row.Cells["codigoBarra"].Value != null) // Validar filas no vacías
                {
                    try
                    {
                        int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                        decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                        string codigoProducto = textCodigo.Text; 
                        int idP= Convert.ToInt32(row.Cells["idProducto"].Value);

                        // Calcular valores específicos del detalle
                        decimal subtotalDetalle = cantidad * precio;
                        decimal descuentoDetalle = daoVenta.Descuento(subtotalDetalle, descuentoAplicado);
                        decimal ivaDetalle = daoVenta.Iva(subtotalDetalle - descuentoDetalle);
                        decimal totalDetalle = subtotalDetalle - descuentoDetalle + ivaDetalle;



                        
                        clsDetalles.idProducto= idP ;
                        clsDetalles.cantidad = cantidad;
                        clsDetalles.precio = precio;
                        clsDetalles.subtotal = subtotalDetalle;
                        clsDetalles.descuento = descuentoDetalle;
                        clsDetalles.iva = ivaDetalle;
                        clsDetalles.total = totalDetalle;
                        textCodigo.Clear();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al procesar la fila: {ex.Message}");
                    }
                }
            }

            
            try
            {
                daoVenta.insertarVenta(venta, clsDetalles);
                MessageBox.Show("Venta registrada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}");
            }
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