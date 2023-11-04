

using System;

namespace SalesOnline.Application.Dtos.Usuario
{
    public class UsuarioDtoBase
    {        
        public String? nombreCompleto { get; set; }
        public String? correo { get; set; }
        public String? clave { get; set; }
        public int? idRol { get; set; }
    }
}
