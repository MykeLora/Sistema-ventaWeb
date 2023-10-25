using SalesOnline.Api.Models.Core;

namespace SalesOnline.Api.Models.Module_Usuario
{
    public class UsuarioUpdateModel : UsuarioBaseModel
    {
        public int Usuarioid { get; set; }
        public int ChangeUser { get; internal set; }
    }
}
