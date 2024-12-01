using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databasesproyect.Clases
{
    internal class ClsVentasPorMes
    {
        public int folio { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public string empleado { get; set; }
        public decimal total { get; set; }
        public int cantidad { get; set; }
    }
}
