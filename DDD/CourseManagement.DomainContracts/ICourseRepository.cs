using Common.Utils.Repository;
using CourseManagement.DomainEntities.Model;
using System;

namespace CourseManagement.DomainContracts
{
    public interface ICourseRepository : IRepository<Course>
    {
    }
}
