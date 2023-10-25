using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public  class Venta : BaseEntity
    {
        [Key]
        public int idVenta { get; set; }
        public String? numeroDocumento {  get; set;}
        public String? tipoPago { get; set; }
        public Decimal? total { get; set; }


    }
}
