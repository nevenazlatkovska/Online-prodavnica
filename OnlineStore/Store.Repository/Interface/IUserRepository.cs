using Store.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<StoreApplicationUser> GetAll();
        StoreApplicationUser Get(string id);
        void Insert(StoreApplicationUser entity);
        void Update(StoreApplicationUser entity);
        void Delete(StoreApplicationUser entity);
    }
}
