using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.DomainEntities.Model;

namespace CourseManagement.ApplicationServices.Contracts
{
    public interface ICourseManager
    {
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void AddCourseIntake(int courseId, CourseIntake intake );
        void UpdateCourseIntake(CourseIntake intake);
        List<Course> GetAllCourses();
        List<CourseIntake> GetAllCourseIntakes(int courseId);
    }
}
