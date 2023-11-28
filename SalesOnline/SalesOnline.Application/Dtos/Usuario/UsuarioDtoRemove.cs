using SalesOnline.Application.Dtos.Base;

namespace SalesOnline.Application.Dtos.Usuario
{
    public class UsuarioDtoRemove : DtoBase
    {
        public int Id { get; set; }
        public bool Eliminado { get; set; }
    }
}
