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
        public Student GetStudentById(string id) => StudentsDAO.Instance.GetStudentById(id);

        public void InsertStudent(Student student) => StudentsDAO.Instance.InsertStudent(student);

        public void UpdateStudent(Student student) => StudentsDAO.Instance.UpdaterStudent(student);
    }
}
