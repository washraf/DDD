using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.BaseClasses.Contexts;
using Microsoft.EntityFrameworkCore;
using Site.DataSource.UnitOfWork;
using Site.DomainEntities.Model;

namespace Site.DataSource.Context
{
    public class SiteContext : BaseContext,ISiteUnitOfWork
    {
        public DbSet<CenterEvent> CenterEvents { set; get; }
        /// <summary>
        /// ReadOnly Don't Include In Migrations
        /// </summary>
        //public DbSet<Course> Courses { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseIntake>(e => e.ToTable("CourseIntakes"));
            base.OnModelCreating(modelBuilder);
        }
    }
}
