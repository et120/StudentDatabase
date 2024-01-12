using Microsoft.AspNetCore.Mvc;
using StudentDatabase.Models;
using StudentDatabase.Services.Students;

namespace StudentDatabase.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    [Route("GetStudents")]
    public List<Student> GetStudents()
    {
        return _studentService.GetStudents();
    }

    [HttpPost]
    [Route("AddStudents")]
    public List<Student> AddStudents(string firstName, string lastName, string hobby)
    {
        return _studentService.AddStudents(firstName, lastName, hobby);
    }

    [HttpDelete]
    [Route("DeleteStudents")]
    public List<Student> DeleteStudents(string firstName)
    {
        return _studentService.DeleteStudents(firstName);
    }
}
