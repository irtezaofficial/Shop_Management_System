using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.User
{
    public interface IUserService : ITransientService
    {
        bool RegisterUser(RegisterUserRequest request);
    }
}
