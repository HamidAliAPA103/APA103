using _26_DynamicPropertiesViewModel.Models;
using _26_DynamicPropertiesViewModel.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _26_DynamicPropertiesViewModel.Controllers
{
    public class HomeController : Controller
    {

        List<Student>_students=new List<Student>
        {
            new Student{Id=1,Name="Hemid",Age=21},
            new Student{Id=2,Name="Cumsud",Age=20},
            new Student{Id=3,Name="Mehemmed",Age=19}
        };


        List<Teacher> _teachers = new List<Teacher>
        {
            new Teacher{Id=1,Name="Leyla", Salary=2200 },
            new Teacher{Id=2,Name="Seid", Salary=2200 },
            new Teacher{Id=1,Name="Fizuli", Salary=2200 },
        };

       


        public IActionResult Index()
        {
            //TempData["Name"] = "Kamran";
            HomeVM homeVM = new()
            {
                Teachers = _teachers,
                Students = _students
            };



            return View(homeVM);
        }

        public IActionResult Details()
        {
            return View();
        }

        [Route("Carparativ-satislar")]
        public IActionResult CorporativeSales()
        {
            return View();
        }
    }
}
