using System.Linq;
using System.Collections.Generic;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface ICourseRepository
    {
         IQueryable<Course> GetCourses();
         void Add(Course course);
    }
}