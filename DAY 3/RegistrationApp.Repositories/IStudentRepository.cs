using System.Collections.Generic;
using RegistrationApp.Entities;

namespace RegistrationApp.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        void Add(Student student);
    }
}
