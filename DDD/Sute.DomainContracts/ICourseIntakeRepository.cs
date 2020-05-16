using Common.Utils.Repository;
using Site.DomainEntities.Model;
using System;

namespace Site.DomainContracts
{
    public interface ICourseIntakeRepository : IReadOnlyRepository<CourseIntake>
    {
    }
}
