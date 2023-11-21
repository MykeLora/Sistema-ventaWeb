namespace SalesOnline.Api.Models.Core
{
    public class UsuarioBaseModel : ModelBase
    {
        public int idUsuario {  get; set; }
        public int? idRol { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public string? Nombre { get; set; }
        public String? correo { get; set; }
        public String? clave { get; set; }       
        public bool? esActivo { get; set; }
    }
}
