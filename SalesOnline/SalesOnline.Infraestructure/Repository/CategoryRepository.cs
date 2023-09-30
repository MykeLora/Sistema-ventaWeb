using SalesOnline.Domain.Entities;
using SalesOnline.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Infraestructure.Repository
{
    public class CategoryRepository : ICategoyRepository
    {
        public List<Category> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Category GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public List<Producto> GetProductosbyid(int idcategoria)
        {
            throw new NotImplementedException();
        }

        public void Remove(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
