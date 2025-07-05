using RegistrationApp.Entities;

namespace RegistrationApp.Services
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
    }
}
