using SalesOnline.Api.Models.Core;

namespace SalesOnline.Api.Models.Module_Usuario
{
    public class UsuarioGetAllModel : UsuarioBaseModel
    {
        public int Usuarioid {  get; set; }
        public DateTime? ChanageDate { get; internal set; }
        public int IdUsuarioCreacion { get; internal set; }
    }
}
