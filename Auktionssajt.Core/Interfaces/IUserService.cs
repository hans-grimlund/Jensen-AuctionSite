using Auktionssajt.Domain;
using Auktionssajt.Domain.DTOs;
using Auktionssajt.Domain.Models;

namespace Auktionssajt.Core.Interfaces
{
    public interface IUserService
    {
        LoginResponse Login(LoginRequestModel request);
        Status NewUser(NewUserModel user);
        Status UpdateUser(UpdateUserModel model, int userId);
        Status DeleteUser(int id, int userId);
        UserDTO GetUser(int id);
        List<UserDTO> GetAllUsers();
    }
}