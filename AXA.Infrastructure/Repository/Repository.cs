using AXA.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AXA.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
    {
        private static readonly IList<TEntity> entities = new List<TEntity>();

        public TEntity Add(TEntity entity)
        {
            entities.Add(entity);
            return entity;
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return entities.Where(predicate);
        }

        public TEntity FirstOrDefault(Func<TEntity, bool> predicate)
        {
            return entities.FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities;
        }

        public void Remove(Func<TEntity, bool> predicate)
        {
            var entity = FirstOrDefault(predicate);
            entities.Remove(entity);
        }

        public void Clear()
        {
            entities.Clear();
        }
    }
}