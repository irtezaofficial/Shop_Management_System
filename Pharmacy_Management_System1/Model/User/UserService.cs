using ShopMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
                IsActive = true,
            };
            this._context.Users.Add(newUser);
            this._context.SaveChanges();
            return "User Registered.";
        }

        public LoginResponse LoginUser(LoginRequest request)
        {
            var findUser = this._context.Users.FirstOrDefault(u => u.Email.Contains(request.Email));
            if (findUser == null)
            {
                return new LoginResponse
                {
                    IsAdmin = false,
                    UserId = 0,
                    Message = "Invalid Email."
                };

            }

            if (findUser.Password != request.Password)
            {
                return new LoginResponse
                {
                    IsAdmin = false,
                    UserId = 0,
                    Message = "Invalid Password."
                };
            }

            return new LoginResponse
            {
                IsAdmin = findUser.Email == "admin@shop.com",
                UserId = findUser.Id,
                Message = "Login Successfull."
            };
        }

        public string ActivateOrDeactivateAccount(int userId, bool active)
        {
            var findUser = this._context.Users.FirstOrDefault(u => u.Id == userId);
            if (findUser == null)
                return "An Error Occured.";
            findUser.IsActive = active;
            this._context.Users.AddOrUpdate(findUser);
            this._context.SaveChanges();
            if(active)
                return "Account Activated.";
            else
            {
                return "Account Deactivated.";
            }
        }
    }
}
