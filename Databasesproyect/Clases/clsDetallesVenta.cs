using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databasesproyect.Clases
{
    internal class clsDetallesVenta
    {
        public int idDetalle { get; set; }
        public int idventa { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal descuento { get; set; } 
        public decimal iva {  get; set; }
        public decimal subtotal { get; set; }
        public decimal total { get; set; }

    }
}
