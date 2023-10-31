using DataAccessObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetUserByUseNameAndPassword(string username, string password)

            => UserDAO.Instance.GetUserByUseNameAndPassword(username, password);
        public User GetUserById(string id) => UserDAO.Instance.GetUserById(id);

        public IEnumerable<User> GetAllUser() => UserDAO.Instance.GetUsers();
    }

}
