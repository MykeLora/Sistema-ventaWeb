using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public class Rol : BaseEntity
    {
        [Key]
        public int idRol { get; set; }
        public String? nombre{ get; set; }
       

    }
}
