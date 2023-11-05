using BusinessObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SampleTestController : ControllerBase
    {
        private ISampleTestRepository _SampleTestRepository;

        public SampleTestController(ISampleTestRepository sampleTestRepository)
        {
            _SampleTestRepository = sampleTestRepository;
        }

        [HttpGet("getallsampletest")]
        public IActionResult GetAll()
        {
            List<SampleTest> sampletest = _SampleTestRepository.GetAllSampleTests();
            return Ok(sampletest);
        }

        [HttpGet("getsampleinfobyid")]
        public IActionResult GetSampleTestById(string id)
        {
            QuestionSampleTest? sampletestInfo = _SampleTestRepository.GetById(id);
            if(sampletestInfo == null)
            {
                return NotFound();
            }
            return Ok(sampletestInfo);
        }

        [HttpPost("insertsampletest")]
        public IActionResult InsertSampleTest(SampleTest sampletest)
        {
            var questions = _SampleTestRepository.InsertSampleTest(sampletest);
            return Ok("Inserted successfully");
        }
    }
}
