using StudentDatabase.Models;

namespace StudentDatabase.Services.Students;

public interface IStudentService
{
    List<Student> GetStudents();
    List<Student> AddStudents(string firstName, string lastName, string hobby);
    List<Student> DeleteStudents(string firstName);
}
