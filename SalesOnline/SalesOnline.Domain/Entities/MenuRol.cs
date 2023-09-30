using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public class MenuRol : BaseEntity
    {
        public int idMenuRol { get; set; }
        public int idMenu { get; set;}
        public int idRol { get; set; }

    }
}
