using SalesOnline.Application.Dtos.Base;
using System;

namespace SalesOnline.Application.Dtos.Usuario
{
    public class UsuarioDtoRemove : DtoBase
    {
        public int idUsuario { get; set; }                
        public bool Eliminado { get; set; }
        
    }
}
