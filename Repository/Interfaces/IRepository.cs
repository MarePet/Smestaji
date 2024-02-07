using Domain;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity key);
        TEntity Get(TEntity key);
        List<TEntity> GetAll(TEntity entity);
        List<TEntity> Search(IDomainObject obj);
    }
}
