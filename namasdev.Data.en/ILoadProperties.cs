using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace namasdev.Data
{
    public interface ILoadProperties<TEntity>
        where TEntity : class
    {
        IEnumerable<Expression<Func<TEntity, object>>> BuildPaths();
    }
}
