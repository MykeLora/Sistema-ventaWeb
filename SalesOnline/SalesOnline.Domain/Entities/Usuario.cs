using SalesOnline.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesOnline.Domain.Entities
{
    public class Usuario : Person
    {
        [Key]
        public int idUsuario {  get; set; }
        
        public bool? esActivo { get; set; }
       

    }
}
