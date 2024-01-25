using Auktionssajt.Domain.DTOs;
using Auktionssajt.Domain.Models;

namespace Auktionssajt.Core.Interfaces
{
    public interface IUserService
    {
        Status NewUser(NewUserModel user);
        Status DeleteUser(int id, int userId);
        UserDTO GetUser(int id);
        UserDTO GetUser(string userName);
        List<UserDTO> GetAllUsers();
    }
}