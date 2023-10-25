using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public  class NumeroDocumento : BaseEntity
    {
        [Key]
        public int idNumeroDocumento { get; set; }
        public int ultimoNumero { get; set; }
        public DateTime? FechaRegistro { get;set; }


    }
}
