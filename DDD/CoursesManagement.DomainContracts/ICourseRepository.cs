using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utils.Repository;
using CourseManagement.DomainEntities.Model;

namespace CoursesManagement.DomainContracts
{
    public interface ICourseRepository:IRepository<Course>
    {
    }
}
