using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BaseClasses.Contexts
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext() :
            base("Data Source=.;Initial Catalog=DDD;Integrated Security=True")
        {

        }

        public void Commit()
        {
            this.SaveChanges();
        }

        public DbSet<TEntityType> GetDBSet<TEntityType>() where TEntityType : class, new()
        {
            return this.Set<TEntityType>();
        }
    }
}
