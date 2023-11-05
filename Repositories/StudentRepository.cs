using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetAllStudents() => StudentsDAO.Instance.GetAllStudents();

        public Student GetStudentById(string id) => StudentsDAO.Instance.GetStudentById(id);

        public bool InsertStudent(Student student) => StudentsDAO.Instance.InsertStudent(student);

        public bool UpdateStudent(Student student) => StudentsDAO.Instance.UpdaterStudent(student);
   
    }
}
