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
    public class SiteContext : BaseContext<SiteContext>,ISiteUnitOfWork
    {
        public DbSet<CenterEvent> Events { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<CourseIntake> Intakes { set; get; }
        public DbSet<User> Users { set; get; }
        
    }
}
