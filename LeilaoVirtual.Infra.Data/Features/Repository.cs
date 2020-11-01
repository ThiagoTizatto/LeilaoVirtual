using LeilaoVirtual.Domain.Base;
using LeilaoVirtual.Domain.Base.Interfaces;
using LeilaoVirtual.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LeilaoVirtual.Infra.Data.Features
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly LeilaoDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(LeilaoDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public  IList<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate).ToList();
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual  IList<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual TEntity  Add(TEntity entity)
        {
            DbSet.Add(entity);

            Db.SaveChanges();

            return entity;
        }

        public virtual void Update(TEntity entity)
        {
            DbSet.Update(entity);
            Db.SaveChanges();
    
        }

        public virtual void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
            Db.SaveChanges();
        }


        public void Dispose()
        {
            Db?.Dispose();
        }

    }
}
