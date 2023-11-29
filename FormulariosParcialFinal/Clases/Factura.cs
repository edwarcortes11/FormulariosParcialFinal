using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulariosParcialFinal.Clases
{
    public class Factura
    {
        public int IDFACTURA { get; set; }
        public int ID_CLIENTE { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public Nullable<decimal> SUBTOTAL { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
    }
}