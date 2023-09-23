using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public String? correo { get; set; }
        public String? clave { get; set; }
        public int? idRol { get; set; }
    }
}
