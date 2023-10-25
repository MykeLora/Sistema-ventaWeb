using SalesOnline.Domain.Entities;
using SalesOnline.Domain.Repository;
using SalesOnline.Infraestructure.Context;
using SalesOnline.Infraestructure.Core;
using SalesOnline.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

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

        public List<Usuario> GetUsuariosByidUsuario(int Usuarioid)
        {
            return this.context.Usuario.Where(usu => usu.idUsuario == Usuarioid && !usu.Eliminado).ToList();
        }
    }
}