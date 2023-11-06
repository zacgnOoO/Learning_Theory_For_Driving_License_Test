using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SampleTestDAO
    {
        public static SampleTestDAO instance = null;
        public static object lockObject = new object();

        private SampleTestDAO() { }
        public static SampleTestDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new SampleTestDAO();
                    }
                }
                return instance;
            }
        }

        public List<SampleTest> GetAll()
        {
            List<SampleTest> listSampleTest = new List<SampleTest>();
            try
            {
                using (var context = new Swp391Context())
                {
                    listSampleTest = context.SampleTests.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listSampleTest;
        }
        public Question GetQuestionById(int id)
        {
            using var db = new Swp391Context();
            return db.Questions.SingleOrDefault(s => s.QuestionId == id);
        }


        public bool InsertSampleTest(SampleTest SampleTest)
        {
            using var db = new Swp391Context();
            db.SampleTests.Add(SampleTest);
            db.SaveChanges();
            return true;
        }
        public bool UpdaterSampleTest(SampleTest SampleTest)
        {
            using var db = new Swp391Context();
            db.SampleTests.Update(SampleTest);
            db.SaveChanges();
            return true;
        }
    }
}
