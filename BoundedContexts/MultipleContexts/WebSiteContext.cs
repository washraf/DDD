using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Model;
using Microsoft.EntityFrameworkCore;

namespace MultipleContext
{
    public class WebSiteContext:BaseContext<WebSiteContext>
    {
        public DbSet<CenterEvent> Events { set; get; } 
        public DbSet<Course> Courses { set; get; }
        public DbSet<User> Users { set; get; }
         
    }
}
