using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Core
{
    public abstract class Person : BaseEntity
    {
        public DateTime? fechaRegistro { get; set; }
        public String? nombre { get; set; }
        public String? correo { get; set; }
        public String? clave { get; set; }
        public int? idRol { get; set; }

       
    }
}
