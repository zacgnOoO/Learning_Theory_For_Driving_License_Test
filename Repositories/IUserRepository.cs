using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserRepository
    {
        User GetUserByUseNameAndPassword(string username, string password);
        User GetUserById(string id);
        IEnumerable<User> GetAllUser();

        bool RegisterUser(User user);
    }
}
