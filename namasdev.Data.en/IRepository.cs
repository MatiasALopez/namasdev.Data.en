using System;
using System.Collections.Generic;

using namasdev.Core.Entity;

namespace namasdev.Data
{
    public interface IRepository<TEntity, TId> : IReadOnlyRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
        where TId : IEquatable<TId>
    {
        void Add(IEnumerable<TEntity> entities, int batchSize = 100);
        void Add(TEntity entity);
        void Update(IEnumerable<TEntity> entities, int batchSize = 100);
        void Update(TEntity entity);
        void UpdateProperties(IEnumerable<TEntity> entities, int batchSize = 100, params string[] properties);
        void UpdateProperties(TEntity entity, params string[] properties);
        void UpdateDeletedProperties(TEntity entity);
        void UpdateDeletedProperties(IEnumerable<TEntity> entities, int batchSize = 100);
        void Delete(IEnumerable<TEntity> entities, int batchSize = 100);
        void Delete(TEntity entity);
        void DeleteByIds(IEnumerable<TId> ids, int batchSize = 100);
        void DeleteById(TId id);
    }
}
