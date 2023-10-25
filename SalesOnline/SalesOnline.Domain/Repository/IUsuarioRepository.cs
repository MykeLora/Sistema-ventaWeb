using SalesOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SalesOnline.Infraestructure.Repository
{
    public interface IUsuarioRepository
    {
        void Save(Usuario usuario);
        void Update(Usuario usuario);
        void Remove (Usuario usuario);
        List<Usuario> GetUsuarios();
        Usuario GetUsuario(int id);        
    }
}