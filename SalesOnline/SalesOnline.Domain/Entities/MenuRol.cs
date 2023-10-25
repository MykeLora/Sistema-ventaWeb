using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public class MenuRol : BaseEntity
    {
        [Key]
        public int idMenuRol { get; set; }
        public int idMenu { get; set;}
        public int idRol { get; set; }

    }
}
