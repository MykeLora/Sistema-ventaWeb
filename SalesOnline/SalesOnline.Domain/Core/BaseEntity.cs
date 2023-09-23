
using System;

namespace SalesOnline.Domain.Core
{
   public  abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.fechaRegistro = DateTime.Now;
            this.Nombre = null;
        }

        public virtual string? Nombre { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public int? esActivo { get; set; }
        



    }
}
