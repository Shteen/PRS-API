using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface IUserService
    {
        Task<List<UserResponse>> GetAll();
        Task<LoginResponse> UserLogin(LoginRequest request);
    }
}
