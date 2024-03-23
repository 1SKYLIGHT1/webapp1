using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentStorageService _studentStorageService;
        public StudentController(StudentStorageService studentStorageService)
        {
            _studentStorageService = studentStorageService;
        }
        public IActionResult Index()
        {
            var dbResult = _studentStorageService.GetStudentList();
            return View(dbResult);
        }


        public IActionResult Add(Student newStudent)
        {
            _studentStorageService.AddStudent(newStudent);

            return RedirectToAction("Index");
        }
        //[HttpGet]
        //public int GetFive()
        //{
        //    return 5;
        //}

        [HttpGet]
        public IActionResult Delete(int studentId) 
        {

            _studentStorageService.DeleteStudent(studentId);

            return RedirectToAction("Index");
        }

    }
}
