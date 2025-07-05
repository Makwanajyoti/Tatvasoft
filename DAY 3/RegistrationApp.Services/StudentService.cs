using RegistrationApp.Entities;
using RegistrationApp.Repositories;

namespace RegistrationApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }
    }
}
