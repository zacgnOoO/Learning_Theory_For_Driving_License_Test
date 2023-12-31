﻿using Entities.Models;
using Repositories;
using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class UsersService : IUsersService
    {
        private IUserRepository _users = new UserRepository();
        private readonly IJwtUtils _jwtUtils;

        public UserService(IJwtUtils jwtUtils)
        {
            _jwtUtils = jwtUtils;
        }
        public LoginResponse? Authenticate(LoginRequest model)
        {
            var user = _users.GetUserByUseNameAndPassword(model.UserName, model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = _jwtUtils.GenerateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

    }
}
