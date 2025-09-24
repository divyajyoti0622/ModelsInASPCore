using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;
using ModelsInASPCore.Repository;

namespace ModelsInASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

       public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudentModel> getAllStudents()
        {
             return _studentRepository.getAllStudents();
        }

        // get by name
        public StudentModel getByName(string name)
        {
            return _studentRepository.getStudentByName(name);
        }
        public IActionResult Index()
        {
            //var students = new List<StudentModel>
            //    {
            //        new StudentModel { Rollno = 1, Name = "Divya", Gender = "Female", Age = 24 },
            //        new StudentModel { Rollno = 2, Name = "Jyoti", Gender = "Female", Age = 25 },
            //        new StudentModel { Rollno = 3, Name = "Punam", Gender = "Female", Age = 27 }


            //    };

                    //var students = new List<StudentModel>();

                    //students.Add(new StudentModel { Rollno = 1, Name = "Divya", Gender = "Female", Age = 24 });
                    //students.Add(new StudentModel { Rollno = 2, Name = "Jyoti", Gender = "Female", Age = 25 });
                    //students.Add(new StudentModel { Rollno = 3, Name = "Punam", Gender = "Female", Age = 27 });

                    //ViewData["StudentModel"] = students;

                    //ViewData["myStudents"] = students;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
