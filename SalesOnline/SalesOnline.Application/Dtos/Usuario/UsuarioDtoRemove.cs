

using System;

namespace SalesOnline.Application.Dtos.Usuario
{
    public class UsuarioDtoRemove
    {
        public int idUsuario { get; set; }
        public int? IdUsuarioElimino { get; set; }
        public DateTime? FechaElimino { get; set; }
        public bool Eliminado { get; set; }
    }
}
