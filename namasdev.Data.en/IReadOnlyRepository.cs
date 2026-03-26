using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using namasdev.Core.Entity;
using namasdev.Core.Linq;

namespace namasdev.Data
{
    public interface IReadOnlyRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
        where TId : IEquatable<TId>
    {
        TEntity Get(TId id, bool includeDeleted = false);
        Task<TEntity> GetAsync(TId id, bool includeDeleted = false, CancellationToken ct = default);
        TEntity Get(TId id, IEnumerable<string> loadProperties, bool includeDeleted = false);
        Task<TEntity> GetAsync(TId id, IEnumerable<string> loadProperties, bool includeDeleted = false, CancellationToken ct = default);
        TEntity Get(TId id, IEnumerable<Expression<Func<TEntity, object>>> loadProperties, bool includeDeleted = false);
        Task<TEntity> GetAsync(TId id, IEnumerable<Expression<Func<TEntity, object>>> loadProperties, bool includeDeleted = false, CancellationToken ct = default);
        TEntity Get(TId id, ILoadProperties<TEntity> loadProperties, bool includeDeleted = false);
        Task<TEntity> GetAsync(TId id, ILoadProperties<TEntity> loadProperties, bool includeDeleted = false, CancellationToken ct = default);
        IEnumerable<TEntity> GetList(bool includeDeleted = false, OrderAndPagingParameters op = null);
        Task<IEnumerable<TEntity>> GetListAsync(bool includeDeleted = false, OrderAndPagingParameters op = null, CancellationToken ct = default);
        IEnumerable<TEntity> GetList(IEnumerable<string> loadProperties, bool includeDeleted = false, OrderAndPagingParameters op = null);
        Task<IEnumerable<TEntity>> GetListAsync(IEnumerable<string> loadProperties, bool includeDeleted = false, OrderAndPagingParameters op = null, CancellationToken ct = default);
        IEnumerable<TEntity> GetList(IEnumerable<Expression<Func<TEntity, object>>> loadProperties, bool includeDeleted = false, OrderAndPagingParameters op = null);
        Task<IEnumerable<TEntity>> GetListAsync(IEnumerable<Expression<Func<TEntity, object>>> loadProperties, bool includeDeleted = false, OrderAndPagingParameters op = null, CancellationToken ct = default);
        IEnumerable<TEntity> GetList(ILoadProperties<TEntity> loadProperties, bool includeDeleted = false, OrderAndPagingParameters op = null);
        Task<IEnumerable<TEntity>> GetListAsync(ILoadProperties<TEntity> loadProperties, bool includeDeleted = false, OrderAndPagingParameters op = null, CancellationToken ct = default);
        bool ExistsById(TId id, bool includeDeleted = false);
        Task<bool> ExistsByIdAsync(TId id, bool includeDeleted = false, CancellationToken ct = default);
    }
}
