using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utils.Repository;
using Site.DomainEntities.Model;

namespace Site.DomainContracts
{
    public interface ICourseIntakeRepository:IReadOnlyRepository<CourseIntake>
    {
    }
}
