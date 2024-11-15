using ProyectoDeBaseDeDatos;
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
    public partial class ConsultarEmpleados : Form
    {
        public ConsultarEmpleados()
        {
            InitializeComponent();
        }

        private void consultarEmpleado_Click(object sender, EventArgs e)
        {
            int idEmpleado;
            if (int.TryParse(txtIdEmpleado.Text, out idEmpleado))
            {
                DaoEmpleados daoEmpleado = new DaoEmpleados();

                
                clsEmpleados empleado = daoEmpleado.consultarEmpleado(idEmpleado);

                if (empleado != null)
                {
                    // Asigna los datos al DataGridView, por ejemplo
                    dataGridViewEmpleados.Rows.Clear();
                    dataGridViewEmpleados.Rows.Add(empleado.idEmpleado, empleado.clave, empleado.username,
                                                   empleado.nombre, empleado.apellido, empleado.telefono,
                                                   empleado.curp, empleado.edad);
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
            }
        }
    }
}
