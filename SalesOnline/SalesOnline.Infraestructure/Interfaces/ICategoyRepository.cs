using SalesOnline.Domain.Entities;
using SalesOnline.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Infraestructure.Interfaces
{
    public interface ICategoyRepository : IBaseRepository<Category>
    {
        public List<Producto> GetProductosbyid(int idcategoria);
    }
}
