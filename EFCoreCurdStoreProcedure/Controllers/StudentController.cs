using EFCoreCurdStoreProcedure.Models;
using EFCoreCurdStoreProcedure.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EFCoreCurdStoreProcedure.Controllers
{
    public class StudentController : Controller
    {
        IStudentService _studentService = null;
        
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        } 

        public List<Student> GetStudents(string name)
        {
            return _studentService.GetStudents(name);
        }

        public void SaveOrUpdateStudent(Student student)
        {
            _studentService.SaveOrUpdateStudent(student);   
        }

        public void Delete(int studentId) {
            _studentService.Delete(studentId);
        
        }
    }
}
