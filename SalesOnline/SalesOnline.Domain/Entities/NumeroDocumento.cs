using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public  class NumeroDocumento : BaseEntity
    {
        public int idNumeroDocumento { get; set; }
        public int ultimoNumero { get; set; }
        public DateTime? FechaRegistro { get;set; }


    }
}
