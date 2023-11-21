

using SalesOnline.Application.Dtos.Base;
using System;

namespace SalesOnline.Application.Dtos.Usuario
{
    public class UsuarioDtoBase : DtoBase
    {
        public int? idRol {  get; set; }
        public String? nombre { get; set; }
        public string? correo { get; set; }
        public string? clave { get; set; }
        public DateTime? fechaRegistro { get; set; }                                
    }
}
