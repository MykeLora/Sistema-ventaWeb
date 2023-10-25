namespace SalesOnline.Api.Models.Core
{
    public class UsuarioBaseModel
    {
        public DateTime? fechaRegistro { get; set; }
        public String? nombreCompleto { get; set; }
        public String? correo { get; set; }
        public String? clave { get; set; }
        public int? idRol { get; set; }
        public bool? esActivo { get; set; }
    }
}
