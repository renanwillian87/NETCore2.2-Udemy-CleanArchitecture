using CleanArchitecture.Application.ViewModels;
using System.Collections;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseService
    {
         IEnumerable<CourseViewModel> GetCourses();
         void Create(CourseViewModel courseViewModel);
    }
}