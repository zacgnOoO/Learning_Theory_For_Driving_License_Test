using BusinessObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;


namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private IQuestionRepository _questionRepository;

        public QuestionsController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        [HttpGet("getallquestion")]
        public IActionResult GetAll()
        {
            List<Question> questions = _questionRepository.GetAllQuestions();
            return Ok(questions);
        }

        [HttpGet("getquestionbyid")]
        public IActionResult GetQuestionById(int id) 
        {
            Question questions = _questionRepository.GetById(id);
            return Ok(questions);
        }

        [HttpPost("insertquestion")]
        public IActionResult InsertQuestion(Question question)
        {
            var questions = _questionRepository.InsertQuestion(question);
            return Ok("Inserted successfully");
        }
    }
}
