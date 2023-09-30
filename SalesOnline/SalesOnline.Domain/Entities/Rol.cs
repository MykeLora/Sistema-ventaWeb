using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public class Rol : BaseEntity
    {
        public int idRol { get; set; }
        public String nombre{ get; set; }
        public DateTime? FechaRegistro { get; set; }

    }
}
