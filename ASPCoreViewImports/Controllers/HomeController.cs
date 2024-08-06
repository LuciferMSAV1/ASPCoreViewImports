using ASPCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student {Id = 1,Name = "Kumar",Gender="Male" },
                new Student {Id = 2, Name = "Adil",Gender="Male"},
                new Student {Id = 3, Name = "Natasha",Gender="Female" }
            };

            return View(students);
        }
        public IActionResult About()
        {
            var students = new List<Student>
            {
                new Student {Id = 1,Name = "Kumar",Gender="Male" },
                new Student {Id = 2, Name = "Adil",Gender="Male"},
                new Student {Id = 3, Name = "Natasha",Gender="Female" }
            };

            return View(students);
        }
        public IActionResult Contact()
        {
            var students = new List<Student>
            {
                new Student {Id = 1,Name = "Kumar",Gender="Male" },
                new Student {Id = 2, Name = "Adil",Gender="Male"},
                new Student {Id = 3, Name = "Natasha",Gender="Female" }
            };

            return View(students);
        }
    }
}
