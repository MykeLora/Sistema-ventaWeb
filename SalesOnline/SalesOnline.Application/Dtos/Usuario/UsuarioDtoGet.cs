using System;


namespace SalesOnline.Application.Dtos.Usuario
{
    public class UsuarioDtoGet
    {
        public int idUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? correo { get; set; }
        public String? clave { get; set; }
        public DateTime? fechaCreacion  { get; set; }
        public int? idRol { get; set; }
        public bool? esActivo { get; set; }

    }

}
