using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SalesOnline.Application.Contract;
using SalesOnline.Application.Core;
using SalesOnline.Application.Dtos.Usuario;
using SalesOnline.Application.Excepctions;
using SalesOnline.Domain.Entities;
using SalesOnline.Infraestructure.Interfaces;


namespace SalesOnline.Application.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;        
        private readonly ILogger<UsuarioService> logger;
        private readonly IConfiguration configuration;

        public UsuarioService(IUsuarioRepository usuarioRepository,                              
                              ILogger<UsuarioService> logger,
                              IConfiguration configuration)
        {
            this.usuarioRepository = usuarioRepository;            
            this.logger = logger;
            this.configuration = configuration;
        }


        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.usuarioRepository.GetUsuariosRol();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error Obteniendo los Usuarios.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult result = new ServiceResult();

            try 
            {
                result.Data = this.usuarioRepository.GetUsuariosRol(id);
            }
            catch(Exception ex) 
            {
                result.Success = false;
                result.Message = $"Error Obteniendo el Usuario";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;

        }

        public ServiceResult Remove(UsuarioDtoRemove dtoRemove)
        {
            ServiceResult result= new ServiceResult();

            try 
            {
                Usuario usuario = new Usuario()
                {
                    idUsuario = dtoRemove.idUsuario,
                    Eliminado = dtoRemove.Eliminado,
                    IdUsuarioElimino = dtoRemove.idUsuario,
                    FechaElimino = dtoRemove.FechaMod

                };
                this.usuarioRepository.Remove(usuario);

                result.Message = "El Usuario fue removido correctamente";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error Removido el Usuario";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Save(UsuarioDtoAdd dtoAdd)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                if (string.IsNullOrEmpty(dtoAdd.nombre))
                    throw new UsuarioServiceExcepcion(this.configuration["MensajeValidaciones:usuarioNombreRequerido"]);


                if (dtoAdd.nombre.Length > 100)
                    throw new UsuarioServiceExcepcion(this.configuration["MensajeValidaciones:usuarioNombreLongitud"]);


                Usuario usuario = new Usuario()
                {
                    idUsuario = dtoAdd.idUsuario,
                    nombreCompleto = dtoAdd.nombre,
                    correo = dtoAdd.correo,
                    clave = dtoAdd.clave,
                    idRol = dtoAdd.idRol,
                    fechaRegistro = dtoAdd.fechaRegistro,                    
                };
                this.usuarioRepository.Save(usuario);

                result.Message = "El Usuario fue Guardado correctamente";
            }
            catch (UsuarioServiceExcepcion cex)
            {
                result.Success = false;
                result.Message = cex.Message;
                this.logger.LogError($"{result.Message}", cex.ToString());
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error Guardado el Usuario";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Update(UsuarioDtoUpdate dtoUpdate)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                if (string.IsNullOrEmpty(dtoUpdate.nombre))
                    throw new UsuarioServiceExcepcion(this.configuration["MensajeValidaciones:UsuarioNombreRequerido"]);


                if (dtoUpdate.nombre.Length > 100)
                    throw new UsuarioServiceExcepcion(this.configuration["MensajeValidaciones:UsuarioNombreLongitud"]);

                Usuario usuario = new Usuario()
                {
                    idUsuario = dtoUpdate.idUsuario,
                    nombreCompleto = dtoUpdate.nombre,
                    correo = dtoUpdate.correo,
                    clave = dtoUpdate.clave,
                    idRol = dtoUpdate.idRol,
                    fechaRegistro = dtoUpdate.fechaRegistro,
                };
                this.usuarioRepository.Update(usuario);

                result.Message = "El Usuario fue actualizado correctamente";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error actualizado el Usuario";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }
    }
}
