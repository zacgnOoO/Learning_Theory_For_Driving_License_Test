using Entities.Models;
using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public interface IUsersService
    {
        LoginResponse Authenticate(LoginRequest req);
        User GetById(string id);
        IEnumerable<User> GetAll();
    }
}
