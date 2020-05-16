using Microsoft.EntityFrameworkCore;
using System;

namespace Common.Utils.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        void Commit();
        DbSet<TEntityType> GetDBSet<TEntityType>()
            where TEntityType:class ,new ();
    }
}
