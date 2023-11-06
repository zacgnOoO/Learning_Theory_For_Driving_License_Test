using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SampleTestRepository : ISampleTestRepository
    {
        public List<SampleTest> GetAllSampleTests() => SampleTestDAO.Instance.GetAll();

        public List<QuestionSampleTest> GetById(string id)
        {
            return QuestionSampleTestDAO.Instance.GetBySampleTestId(id);
        }

        public bool InsertSampleTest(SampleTest sampleTest) => SampleTestDAO.Instance.InsertSampleTest(sampleTest);

        public bool UpdateSampleTest(SampleTest sampleTest) => SampleTestDAO.Instance.UpdaterSampleTest(sampleTest);
    }
}
