
using SalesOnline.Domain.Entities;
using SalesOnline.Domain.Repository;
using SalesOnline.Infraestructure.Context;
using SalesOnline.Infraestructure.Core;
using SalesOnline.Infraestructure.Interfaces;
using System.Collections.Generic;

namespace SalesOnline.Infraestructure.Repositories
{
    public class RolRepository : BaseRepository<Rol>, IRolRepository
    {
        public RolRepository(SalesContext context) : base(context) 
        {
        
        }

        public void Remove(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        List<Usuario> IBaseRepository<Usuario>.GetEntities()
        {
            throw new System.NotImplementedException();
        }

        Usuario IBaseRepository<Usuario>.GetEntity(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
