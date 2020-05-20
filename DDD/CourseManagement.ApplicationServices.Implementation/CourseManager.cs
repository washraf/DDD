using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.ApplicationServices.Contracts;
using CourseManagement.DomainContracts;
using CourseManagement.DomainEntities.Model.CourseAggregate;
using CourseManagement.DomainEntities.Model.CourseIntakeAggregate;

namespace CourseManagement.ApplicationServices.Implementation
{
    public class CourseManager:ICourseManager
    {
        private readonly ICourseRepository _courseRepository;

        public CourseManager(ICourseRepository courseRepository )
        {
            _courseRepository = courseRepository;
        }

        public void AddCourse(Course course)
        {
            _courseRepository.Insert(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.Update(course);

        }

        public void AddCourseIntake(int courseId, CourseIntake intake)
        {
            var course = _courseRepository.Get(x => x.Id == courseId).Single();
            course.CourseIntakes.Add(intake);
            _courseRepository.Update(course);
        }

        public void UpdateCourseIntake(CourseIntake intake)
        {
            CourseIntake test = new CourseIntake()
            {
                ToughtCourse = new Course() { CourseName = "C++" }
            };
            test.UpdateSchedule();
        }

        public List<Course> GetAllCourses()
        {
            return _courseRepository.Get().ToList();
        }

        public List<CourseIntake> GetAllCourseIntakes(int courseId)
        {
            return _courseRepository.Get(x => x.Id == courseId).Single().CourseIntakes.ToList();
        }
    }
}
