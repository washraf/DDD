using Common.SharedData.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BaseClasses.Contexts
{
    public class BaseContext : DbContext
    {
        private const string connectionString
            = "Data Source=.;Initial Catalog=DDD;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
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
