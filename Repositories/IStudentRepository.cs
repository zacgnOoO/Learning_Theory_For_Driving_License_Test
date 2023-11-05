using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IStudentRepository
    {
        Student GetStudentById(string id);
        bool InsertStudent(Student student);
        bool UpdateStudent(Student student);    
        List<Student> GetAllStudents();
    }
}
