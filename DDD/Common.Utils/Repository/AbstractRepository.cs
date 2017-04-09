using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using Common.Utils.Repository.Exceptions;
using Common.Utils.UnitOfWork;

namespace Common.Utils.Repository
{
    public abstract class AbstractRepository<TEntityType> : IRepository<TEntityType>, IWriteOnlyRepository<TEntityType> where TEntityType : class, new()
    {
        private IUnitOfWork _unitOfWork;

        private readonly DbSet<TEntityType> _currentSet; 
        public AbstractRepository(IUnitOfWork unitOfWork)
        {
            if(unitOfWork==null)
                throw new ArgumentException("Context Cannot Be Null","context");
            _unitOfWork = unitOfWork;
            _currentSet = unitOfWork.GetDBSet<TEntityType>();
            if (_currentSet == null)
                throw new DbSetNotFoundException("Set Not Found",typeof(TEntityType).Name);

        }
        public IQueryable<TEntityType> Get(Expression<Func<TEntityType, bool>> filter = null,
            Func<IQueryable<TEntityType>, IOrderedQueryable<TEntityType>> orderBy = null,
            params string[] includeProperties)
        {
            IQueryable<TEntityType> query = _currentSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        public void Insert(TEntityType entity)
        {
            _currentSet.Add(entity);
            _unitOfWork.Commit();
        }

        public void Update(TEntityType entity)
        {
            _currentSet.Attach(entity);
            _currentSet.AddOrUpdate(entity);
            _unitOfWork.Commit();

        }

        public void Delete(TEntityType entity)
        {
                _currentSet.Attach(entity);
            _currentSet.Remove(entity);
            _unitOfWork.Commit();
        }
    }
}