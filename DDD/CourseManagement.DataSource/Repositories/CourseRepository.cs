using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utils.Repository;
using CourseManagement.DataSource.UnitOfWork;
using CourseManagement.DomainEntities.Model;
using CoursesManagement.DomainContracts;

namespace CourseManagement.DataSource.Repositories
{
    public class CourseRepository:AbstractRepository<Course>,ICourseRepository
    {
        public CourseRepository(ICourseManagementUnitOfWork context):base(context)
        {
            
        }
    }
}
