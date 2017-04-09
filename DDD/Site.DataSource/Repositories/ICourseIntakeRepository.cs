using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utils.Repository;
using Site.DataSource.Context;
using Site.DataSource.UnitOfWork;
using Site.DomainContracts;
using Site.DomainEntities.Model;

namespace Site.DataSource.Repositories
{
    public class CourseIntakeRepository:AbstractRepository<CourseIntake>,
        ICourseIntakeRepository
    {
        public CourseIntakeRepository(ISiteUnitOfWork context):base(context)
        {
            
        }
    }
}
