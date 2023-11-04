using System;
using SalesOnline.Domain.Entities;
using SalesOnline.Infraestructure.Context;
using SalesOnline.Infraestructure.Core;
using SalesOnline.Infraestructure.Interfaces;
using System.Collections.Generic;
using System.Linq;
using SalesOnline.Infraestructure.Models;

namespace SalesOnline.Infraestructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly SalesContext context;

        public UsuarioRepository(SalesContext context) : base(context)
        {
            this.context = context;
        }

        public override List<Usuario> GetEntities()
        {
            return base.GetEntities().Where(usu => !usu.Eliminado).ToList();
        }        

        
        public List<Usuario> GetUsuariosByidUsuario(int idUsuario)
        {
            return this.context.Usuario.Where(usu => usu.idUsuario == idUsuario && !usu.Eliminado).ToList();
        }

        public List<UsuarioRolModel> GetUsuariosByidRol(int idRol)
        {
            throw new NotImplementedException();
        }
        public List<UsuarioRolModel> GetUsuariosRol()
        {
            var usuarios = (from usu in this.GetEntities()
                            join rol in this.context.rol on usu.idRol equals rol.idRol
                            where !usu.Eliminado
                            select new UsuarioRolModel()
                            {
                                idUsuario = usu.idUsuario,
                                nombreCompleto = usu.nombreCompleto,
                                correo = usu.correo,
                                clave = usu.clave,
                                idRol = usu.idRol,
                                Rol = rol.nombre,
                                fechaRegistro = usu.fechaRegistro
                            }).ToList();

            return usuarios;
        }

        public override void Save(Usuario entity)
        {
            base.Save(entity);
            this.context.SaveChanges();
        }
        public override void Update(Usuario entity)
        {
            Usuario usuario = this.GetEntity(entity.idUsuario);

            usuario.idUsuario = entity.idUsuario;
            usuario.FechaMod = entity.FechaMod;
            usuario.IdUsuarioMod = entity.IdUsuarioMod;
            usuario.nombreCompleto = entity.nombreCompleto;
            usuario.correo = entity.correo;
            usuario.clave = entity.clave;
            usuario.idRol = entity.idRol;

            this.context.Usuario.Update(usuario);
            this.context.SaveChanges();

        }

        public UsuarioRolModel GetUsuariosRol(int Id)
        {
            return this.GetUsuariosRol().SingleOrDefault(usu => usu.idUsuario == Id);
        }

        public override void Remove(Usuario entity)
        {
            Usuario usuario = this.GetEntity(entity.idUsuario);

            usuario.idUsuario = entity.idUsuario;
            usuario.Eliminado = entity.Eliminado;
            usuario.IdUsuarioElimino = entity.IdUsuarioElimino;
            usuario.FechaElimino = entity.FechaElimino;

            this.context.Usuario.Update(usuario);
            this.context.SaveChanges();
        }
    }
}