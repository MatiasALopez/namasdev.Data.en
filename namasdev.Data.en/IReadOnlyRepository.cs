using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using namasdev.Core.Entity;
using namasdev.Core.Linq;

namespace namasdev.Data
{
    public interface IReadOnlyRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
        where TId : IEquatable<TId>
    {
        TEntity Get(TId id, bool includeDeleted = false);
        TEntity Get(TId id, IEnumerable<string> loadProperties, bool includeDeleted = false);
        TEntity Get(TId id, IEnumerable<Expression<Func<TEntity, object>>> loadProperties, bool includeDeleted = false);
        TEntity Get(TId id, ILoadProperties<TEntity> loadProperties, bool includeDeleted = false);
        IEnumerable<TEntity> GetList(bool includeDeleted = false, OrderAndPagingParameters op = null);
        IEnumerable<TEntity> GetList(IEnumerable<string> loadProperties, bool includeDeleted = false, OrderAndPagingParameters op = null);
        IEnumerable<TEntity> GetList(IEnumerable<Expression<Func<TEntity, object>>> loadProperties, bool includeDeleted = false, OrderAndPagingParameters op = null);
        IEnumerable<TEntity> GetList(ILoadProperties<TEntity> loadProperties, bool includeDeleted = false, OrderAndPagingParameters op = null);
        bool ExistsById(TId id, bool includeDeleted = false);
    }
}
