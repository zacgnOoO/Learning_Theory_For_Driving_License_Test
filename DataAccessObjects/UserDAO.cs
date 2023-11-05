using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class UserDAO
    {
        public static UserDAO instance = null;
        public static object lockObject = new object();

        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                }
                return instance;
            }
        }

        public List<User> GetUsers()
        {
            List<User> listUser = new List<User>();
            try
            {
                using (var context = new Swp391Context())
                {
                    listUser = context.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listUser;
        }
        public User GetUserById(string id)
        {
            using var db = new Swp391Context();
            return db.Users.SingleOrDefault(s => s.UserId == id);
        }

        public User GetUserByUseNameAndPassword(string userId, string password)
        {
            using var db = new Swp391Context();
            return db.Users.SingleOrDefault(s => s.UserId == userId && s.Password == password);
        }

        public bool InsertUser(User user)
        {
            try
            {
                using var db = new Swp391Context();
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
