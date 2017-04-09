using System;
using System.Data.Entity;

namespace Common.Utils.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        void Commit();
        DbSet<TEntityType> GetDBSet<TEntityType>()
            where TEntityType:class ,new ();
    }
}
