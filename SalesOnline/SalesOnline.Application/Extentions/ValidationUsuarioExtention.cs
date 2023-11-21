using Microsoft.Extensions.Configuration;
using SalesOnline.Application.Core;
using SalesOnline.Application.Dtos.Usuario;
using SalesOnline.Application.Excepctions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Application.Extentions
{
    public static class ValidationUsuarioExtention
    {
        public static ServiceResult IsStudentValid(this UsuarioDtoBase dtoBase, IConfiguration configuration)
        {

            ServiceResult serviceResult = new ServiceResult();

            if (string.IsNullOrEmpty(dtoBase.nombre))
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioNombreRequerido"]);


            if (dtoBase.nombre.Length > 50)
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioNombreLongitud"]);

            if (string.IsNullOrEmpty(dtoBase.correo))
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioCorreoRequerido"]);

            if (dtoBase.correo.Length > 50)
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioCorreoApellidoLongitud"]);

            if (!dtoBase.fechaRegistro.HasValue)
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioFechaRegistroRequerido"]);



            return serviceResult;
        }
    }
}
}
