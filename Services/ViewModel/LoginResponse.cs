using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModel
{
    public class LoginResponse
    {
        //public long Id { get; set; }
        public string? RoleId { get; set; }
        public string? Username { get; set; }
        public string Token { get; set; }


        public LoginResponse(User user, string token)
        {
            //Id = user.UserId;
            RoleId = user.RoleId;
            Username = user.UserId;
            Token = token;
        }
    }
}
