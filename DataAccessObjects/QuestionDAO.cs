using BusinessObjects.Models;
using Microsoft.Identity.Client.Extensions.Msal;
using static System.Formats.Asn1.AsnWriter;

namespace DataAccessObjects
{
    public class QuestionDAO
    {
        public static QuestionDAO instance = null;
        public static object lockObject = new object();

        private QuestionDAO() { }
        public static QuestionDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new QuestionDAO();
                    }
                }
                return instance;
            }
        }
        public List<Question> GetQuestion()
        {
            List<Question> listQuestion = new List<Question>();
            try
            {
                using (var context = new Swp391Context())
                {
                    listQuestion = context.Questions.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listQuestion;
        }

        public Question GetQuestionById(int id)
        {
            using var db = new Swp391Context();
            return db.Questions.SingleOrDefault(s => s.QuestionId == id);
        }

        public bool InsertQuestion(Question question)
        {
            using var db = new Swp391Context();
            db.Questions.Add(question);
            db.SaveChanges();
            return true;
        }
        public bool UpdaterQuestion(Question question)
        {
            using var db = new Swp391Context();
            db.Questions.Update(question);
            db.SaveChanges();
            return true;
        }
    }
}