using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Core.Bus;
using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(
            ICourseRepository courseRepository,
            IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {

        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}