using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class QuestionSampleTestDAO
    {
        public static QuestionSampleTestDAO instance = null;
        public static object lockObject = new object();

        private QuestionSampleTestDAO() { }
        public static QuestionSampleTestDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new QuestionSampleTestDAO();
                    }
                }
                return instance;
            }
        }

        public List<QuestionSampleTest> GetBySampleTestId(string sampleTestId)
        {
            try
            {
                using (var context = new Swp391Context())
                {
                    var rs = context.QuestionSampleTests.Where(s => s.SampleTestId == sampleTestId).Include(q => q.Question);
                    return rs != null ? rs.ToList() : null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
