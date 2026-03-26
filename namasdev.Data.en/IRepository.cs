using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using namasdev.Core.Entity;

namespace namasdev.Data
{
    public interface IRepository<TEntity, TId> : IReadOnlyRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
        where TId : IEquatable<TId>
    {
        void Add(IEnumerable<TEntity> entities, int batchSize = 100);
        Task AddAsync(IEnumerable<TEntity> entities, int batchSize = 100, CancellationToken ct = default);
        void Add(TEntity entity);
        Task AddAsync(TEntity entity, CancellationToken ct = default);
        void Update(IEnumerable<TEntity> entities, int batchSize = 100);
        Task UpdateAsync(IEnumerable<TEntity> entities, int batchSize = 100, CancellationToken ct = default);
        void Update(TEntity entity);
        Task UpdateAsync(TEntity entity, CancellationToken ct = default);
        void UpdateProperties(IEnumerable<TEntity> entities, int batchSize = 100, params string[] properties);
        Task UpdatePropertiesAsync(IEnumerable<TEntity> entities, int batchSize = 100, string[] properties = null, CancellationToken ct = default);
        void UpdateProperties(TEntity entity, params string[] properties);
        Task UpdatePropertiesAsync(TEntity entity, string[] properties = null, CancellationToken ct = default);
        void UpdateDeletedProperties(TEntity entity);
        Task UpdateDeletedPropertiesAsync(TEntity entity, CancellationToken ct = default);
        void UpdateDeletedProperties(IEnumerable<TEntity> entities, int batchSize = 100);
        Task UpdateDeletedPropertiesAsync(IEnumerable<TEntity> entities, int batchSize = 100, CancellationToken ct = default);
        void Delete(IEnumerable<TEntity> entities, int batchSize = 100);
        Task DeleteAsync(IEnumerable<TEntity> entities, int batchSize = 100, CancellationToken ct = default);
        void Delete(TEntity entity);
        Task DeleteAsync(TEntity entity, CancellationToken ct = default);
        void DeleteByIds(IEnumerable<TId> ids, int batchSize = 100);
        Task DeleteByIdsAsync(IEnumerable<TId> ids, int batchSize = 100, CancellationToken ct = default);
        void DeleteById(TId id);
        Task DeleteByIdAsync(TId id, CancellationToken ct = default);
    }
}
