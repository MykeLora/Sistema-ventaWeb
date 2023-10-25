using SalesOnline.Domain.Entities;
using SalesOnline.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Infraestructure.Interfaces
{
    public interface IMenuRepository : Domain.Repository.IBaseRepository<Menu>
    {
       
    }
}
