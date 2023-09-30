using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public int idMenu { get; set; }
        public String nombre { get; set; }
        public String? icono { get; set; }
        public String? url { get; set; }
    }
}
