using System;
using System.Collections.Generic;

namespace AXA.Domain.Repository
{
    /// <summary>
    /// A Repository interface
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Adds a new entity to the repository
        /// </summary>
        TEntity Add(TEntity entity);

        /// <summary>
        /// Removes an entity
        /// </summary>
        void Remove(Func<TEntity, bool> predicate);

        /// <summary>
        /// Finds entities based on the predicate
        /// </summary>
        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);

        /// <summary>
        /// Returns the first or default of an entity
        /// </summary>
        TEntity FirstOrDefault(Func<TEntity, bool> predicate);

        /// <summary>
        /// Returns all entities
        /// </summary>
        IEnumerable<TEntity> GetAll();
    }
}