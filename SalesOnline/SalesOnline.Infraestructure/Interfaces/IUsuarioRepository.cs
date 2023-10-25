using SalesOnline.Domain.Entities;
using SalesOnline.Domain.Repository;
using System.Collections.Generic;

namespace SalesOnline.Infraestructure.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        List<Usuario> GetUsuariosByidUsuario(int Usuarioid);

    }
}
