using SalesOnline.Application.Core;
using System;


namespace SalesOnline.Application.Core
{
    public interface IBaseService<TDoAdd, TDoUpdate, TDoRemove>
    {
        ServicesResult GetAll();
        ServicesResult GetById(int id);
        ServicesResult Save(TDoAdd dtoAdd);
        ServicesResult Update(TDoUpdate dtoUpdate);
        ServicesResult Remove(TDoRemove dtoRemove);
    }
}
