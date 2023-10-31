using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class StudentsDAO
    {
        public static StudentsDAO instance = null;
        public static object lockObject = new object();

        private StudentsDAO() { }
        public static StudentsDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new StudentsDAO();
                    }
                }
                return instance;
            }
        }
        public Student GetStudentById(string id)
        {
            using var db = new Swp391Context();
            return db.Students.SingleOrDefault(s => s.StudentId==id);
        }

        public void InsertStudent(Student student)
        {
            using var db = new Swp391Context();
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void UpdaterStudent(Student student)
        {
            using var db = new Swp391Context();
            db.Students.Update(student);
            db.SaveChanges();
        }
    }
}
