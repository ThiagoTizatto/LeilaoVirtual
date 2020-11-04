using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LeilaoVirtual.Domain.Base.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Add(TEntity entity);
        TEntity GetById(long id);
        IList<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}
