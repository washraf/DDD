using System;
using System.Linq;
using System.Linq.Expressions;

namespace Common.Utils.Repository
{
    public interface IReadOnlyRepository<TEntityType> where TEntityType : class, new()
    {
        IQueryable<TEntityType> Get(Expression<Func<TEntityType, bool>> filter = null,
            Func<IQueryable<TEntityType>, IOrderedQueryable<TEntityType>> orderBy = null,
            params string[] includeProperties);

    }
}