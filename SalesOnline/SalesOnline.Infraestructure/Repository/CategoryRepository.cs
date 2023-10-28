using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SalesOnline.Domain.Entities;
using SalesOnline.Infraestructure.Context;
using SalesOnline.Infraestructure.Core;
using SalesOnline.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SalesOnline.Infraestructure.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {


        private readonly SalesContext context;
        private readonly ILogger<CategoryRepository> logger;

        public CategoryRepository(SalesContext context,
                                   ILogger<CategoryRepository> logger) : base(context)
        {
            this.context = context;
            this.logger = logger;

        }

        public bool Exists(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> FindAll(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }



        public List<Category> GetEntities()
        {

             throw new NotImplementedException();
        }

        public Category GetEntity(int Id)
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
