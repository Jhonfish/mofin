using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MofinDatos
{
    public class ListTransac
    {
        public string Cod_Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }
        public decimal Compra { get; set; }
        public decimal Venta { get; set; }
    }
}
