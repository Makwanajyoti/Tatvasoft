
using RegistrationApp.Entities;
using RegistrationApp.Repositories;
using System.Collections.Generic;

namespace RegistrationApp.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public List<Student> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(Student student)
        {
            _repository.Add(student);
        }
    }
}
