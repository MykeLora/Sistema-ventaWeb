using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Core
{
    public abstract class Gestion : BaseEntity
    {
        public int? cantidad { get; set; }
        public decimal? precio { get; set; }
        public decimal? total { get; set; }



    }
}
