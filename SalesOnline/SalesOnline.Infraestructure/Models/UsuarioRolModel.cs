﻿

using System;

namespace SalesOnline.Infraestructure.Models
{
    public class UsuarioRolModel
    {
        public int idUsuario { get; set; }
        public String? nombreCompleto { get; set; }
        public String? correo { get; set; }
        public String? clave { get; set; }
        public int? idRol { get; set; }
        public string? Rol { get; set; }
        public DateTime? fechaRegistro { get; set; }
    }
}
