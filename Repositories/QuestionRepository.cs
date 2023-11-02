using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        public List<Question> GetAllQuestions() => QuestionDAO.Instance.GetQuestion();
 
        public Question GetById(int id) => QuestionDAO.Instance.GetQuestionById(id);

        public bool InsertQuestion(Question question) => QuestionDAO.Instance.InsertQuestion(question);

        public bool UpdateQuestion(Question question) => QuestionDAO.Instance.UpdaterQuestion(question);
    }
}
