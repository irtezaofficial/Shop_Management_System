using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.User
{
    public class UserController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public string RegisterUser(RegisterUserRequest request)
        {
            return _userService.RegisterUser(request);
        }

        public LoginResponse LoginUser(LoginRequest request)
        {
            return _userService.LoginUser(request);
        }

        public string ActivateAccount(int userId)
        {
            return _userService.ActivateOrDeactivateAccount(userId, true);
        }

        public string DeactivateAccount(int userId)
        {
            return _userService.ActivateOrDeactivateAccount(userId, false);
        }
    }
}
