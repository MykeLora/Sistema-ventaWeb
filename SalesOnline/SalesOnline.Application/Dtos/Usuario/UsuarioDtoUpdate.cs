

using System;

namespace SalesOnline.Application.Dtos.Usuario
{
    public class UsuarioDtoUpdate : UsuarioDtoBase
    {
        public int idUsuario { get; set; }        
        public DateTime? FechaMod { get; set; }
        public int? IdUsuarioMod { get; set; }

    }
}
