using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Domain.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public void Save(TEntity entity);
        public void Remove(TEntity entity);
        public void Update(TEntity entity);

        public  List<TEntity> GetEntities();
        public TEntity GetEntity(int id);
    }
}
