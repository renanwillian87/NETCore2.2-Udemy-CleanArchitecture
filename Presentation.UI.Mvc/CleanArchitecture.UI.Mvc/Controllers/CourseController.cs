using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.UI.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();

            return View(model);
        }
    }
}