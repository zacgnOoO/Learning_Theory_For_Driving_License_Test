using BusinessObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Repositories;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentsController : ControllerBase
    {
        private IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet("getallstudent")]
        public IActionResult GetAll()
        {
            List<Student> students = _studentRepository.GetAllStudents();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(string id)
        {
            Student stundents = _studentRepository.GetStudentById(id);
            return Ok(stundents);
        }

        [HttpPut("/updateinfostudent")]
        public IActionResult UpdateInfoStudent(Student student)
        {
            var stundents = _studentRepository.UpdateStudent(student);
            return Ok("Update successfully1!");
        }
    }
}
