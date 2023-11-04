using SalesOnline.Domain.Entities;
using SalesOnline.Domain.Repository;
using SalesOnline.Infraestructure.Models;
using System.Collections.Generic;

namespace SalesOnline.Infraestructure.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        List<UsuarioRolModel> GetUsuariosByidRol(int idRol);
        List<UsuarioRolModel> GetUsuariosRol();
        UsuarioRolModel GetUsuariosRol(int Id);
    }
}
