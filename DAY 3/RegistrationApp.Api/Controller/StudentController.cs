using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Entities;
using RegistrationApp.Services;
using System.Collections.Generic;

namespace RegistrationApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return _studentService.GetAll();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            _studentService.Add(student);
            return Ok("Student Registered Successfully");
        }
    }
}
