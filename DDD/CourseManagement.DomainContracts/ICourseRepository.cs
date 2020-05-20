using Common.Utils.Repository;
using CourseManagement.DomainEntities.Model;
using CourseManagement.DomainEntities.Model.CourseAggregate;
using System;

namespace CourseManagement.DomainContracts
{
    public interface ICourseRepository : IRepository<Course>
    {
    }
}
