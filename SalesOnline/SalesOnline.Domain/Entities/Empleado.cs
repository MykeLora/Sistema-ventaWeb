using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Entities
{
   public  class Empleado : Person
    {
        public decimal sueldo { get; set; }
        public String? DepartamentoPertenece {  get; set; }
        public String? Supervisor {  get; set; }

     
    }
}
