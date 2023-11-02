using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISampleTestRepository
    {
        List<SampleTest> GetAllSampleTests();
        QuestionSampleTest? GetById(string id);
        bool InsertSampleTest(SampleTest sampleTest);
        bool UpdateSampleTest(SampleTest sampleTest);
    }
}
