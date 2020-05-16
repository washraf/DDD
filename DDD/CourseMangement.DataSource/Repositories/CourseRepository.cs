using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utils.Repository;
using CourseManagement.DataSource.UnitOfWork;
using CourseManagement.DomainEntities.Model;
using CourseManagement.DomainContracts;

namespace CourseManagement.DataSource.Repositories
{
    public class CourseRepository:AbstractRepository<Course>,ICourseRepository
    {
        public CourseRepository(ICourseManagementUnitOfWork context):base(context)
        {
            
        }
    }
}
