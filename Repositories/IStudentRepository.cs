using Entities.Models;
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
        void InsertStudent(Student student);
        void UpdateStudent(Student student);    
    }
}
