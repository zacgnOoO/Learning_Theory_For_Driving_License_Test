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
        Task<bool> Authenticate(LoginRequest req);
    }
}
