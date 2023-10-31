using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IQuestionRepository
    {
        List<Question> GetAllQuestions();
        Question GetById(string id);
        bool InsertQuestion(Question question);
        bool UpdateQuestion(Question question);
    }
}
