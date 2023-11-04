using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using SalesOnline.Application.Contract;
using SalesOnline.Application.Core;
using SalesOnline.Application.Dtos.Usuario;
using SalesOnline.Domain.Entities;
using SalesOnline.Infraestructure.Interfaces;


namespace SalesOnline.Application.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;        
        private readonly ILogger<UsuarioService> logger;

        public UsuarioService(IUsuarioRepository usuarioRepository,                              
                              ILogger<UsuarioService> logger)
        {
            this.usuarioRepository = usuarioRepository;            
            this.logger = logger;
        }


        public ServicesResult GetAll()
        {
            ServicesResult result = new ServicesResult();
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

        public ServicesResult GetById(int id)
        {
            ServicesResult result = new ServicesResult();

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

        public ServicesResult Remove(UsuarioDtoRemove dtoRemove)
        {
            ServicesResult result= new ServicesResult();

            try 
            {
                Usuario usuario = new Usuario()
                {
                    idUsuario = dtoRemove.idUsuario,
                    IdUsuarioElimino = dtoRemove.IdUsuarioElimino,
                    FechaElimino = dtoRemove.FechaElimino,
                    Eliminado = dtoRemove.Eliminado

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

        public ServicesResult Save(UsuarioDtoAdd dtoAdd)
        {
            ServicesResult result = new ServicesResult();

            try
            {
                Usuario usuario = new Usuario()
                {
                    nombreCompleto = dtoAdd.nombreCompleto,
                    correo = dtoAdd.correo,
                    clave = dtoAdd.clave,
                    idRol = dtoAdd.idRol,
                    fechaRegistro = dtoAdd.fechaRegistro
                };
                this.usuarioRepository.Save(usuario);

                result.Message = "El Usuario fue Guardado correctamente";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error Guardado el Usuario";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServicesResult Update(UsuarioDtoUpdate dtoUpdate)
        {
            ServicesResult result = new ServicesResult();

            try
            {
                Usuario usuario = new Usuario()
                {
                    idUsuario = dtoUpdate.idUsuario,
                    nombreCompleto = dtoUpdate.nombreCompleto,
                    correo = dtoUpdate.correo,
                    clave = dtoUpdate.clave,
                    idRol = dtoUpdate.idRol,
                    FechaMod = dtoUpdate.FechaMod,
                    IdUsuarioMod = dtoUpdate.IdUsuarioMod
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
