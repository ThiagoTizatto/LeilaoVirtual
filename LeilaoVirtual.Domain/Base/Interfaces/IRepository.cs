using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LeilaoVirtual.Domain.Base.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Adicionar(TEntity entity);
        TEntity ObterPorId(Guid id);
        IList<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);

    }
}
