﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.User
{
    public class UserController
    {
        private readonly IUserService _userService;
        //public UserController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        public bool RegisterUser(RegisterUserRequest request)
        {
            return _userService.RegisterUser(request);
        }
    }
}
