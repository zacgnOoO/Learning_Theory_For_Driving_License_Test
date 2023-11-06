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
        List<QuestionSampleTest> GetById(string id);
        QuestionSampleTest? GetBySampleTestIdAndQuestionId(string sampleTestId, int questId);
        bool InsertSampleTest(SampleTest sampleTest);
        bool UpdateSampleTest(SampleTest sampleTest);
    }
}
