using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulariosParcialFinal.Clases
{
    public class Producto
    {
        public int IDPRODUCTO { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
       
    }
}