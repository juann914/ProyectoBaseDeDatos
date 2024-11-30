using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databasesproyect.Clases
{
    internal class clsVentas
    {
        public int idventa {  get; set; }
        public decimal descuento { get; set; }
        public decimal iva {  get; set; }
        public decimal subtotal { get; set; }
        public decimal total { get; set; }
        public String fechaVenta { get; set; }
        public int idEmpleado { get; set; }
        public int idCliente { get; set; }
        
    }
}
