using RegistrationApp.Entities;
using System.Collections.Generic;

namespace RegistrationApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new();

        public List<Student> GetAll()
        {
            return _students;
        }

      
        public void Add(Student student)
        {
            student.Id = _students.Count + 1;
            _students.Add(student);
        }

    }
}
