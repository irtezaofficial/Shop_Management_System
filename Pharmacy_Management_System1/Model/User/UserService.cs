﻿using ShopMigrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System1.Model.User
{
    public class UserService : IUserService
    {
        private ShopDbContext _context = new ShopDbContext();
        public UserService(ShopDbContext shopDbContext)
        {
            _context = shopDbContext;
        }
        public string RegisterUser(RegisterUserRequest request)
        {
            var findUser = this._context.Users.FirstOrDefault(u => u.Email.Contains(request.Email));
            if(findUser != null)
                return "User Already Exists.";

            if (request.ConfirmPassword != request.Password)
                return "Passwords does not match.";

            var newUser = new UserEntity()
            {
                Email = request.Email,
                Password = request.Password,
                Name = request.Name,
                Username = request.Email,
            };
            this._context.Users.Add(newUser);
            this._context.SaveChanges();
            return "User Registered.";
        }

        public string LoginUser(LoginRequest request)
        {
            var findUser = this._context.Users.FirstOrDefault(u => u.Email.Contains(request.Email));
            if (findUser == null)
                return "Invalid Email.";

            if (findUser.Password != request.Password)
                return "Invalid Password";

            return "Login Successfull.";
        }
    }
}
