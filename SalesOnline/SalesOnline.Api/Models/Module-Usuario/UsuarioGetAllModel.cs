using SalesOnline.Api.Models.Core;

namespace SalesOnline.Api.Models.Module_Usuario
{
    public class UsuarioGetAllModel : UsuarioBaseModel
    {
        public int idUsuario {  get; set; }
        public DateTime? FechaMod { get;  set; }
        public int IdUsuarioCreacion { get;  set; }
    }
}
