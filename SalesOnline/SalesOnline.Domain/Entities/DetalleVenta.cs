using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public class DetalleVenta : Gestion
    {
        public int idDetalleVenta { get; set; }
        public int? idVenta { get; set;}
        public int? idProducto {  get; set;}

    }
}
