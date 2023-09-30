using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public class Usuario : Person
    {
        public bool? esActivo { get; set; }
        public DateTime? fechaRegistro { get; set; }



    }
}
