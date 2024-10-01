
using BodegaVinos.Dtos;

namespace BodegaVinos.Services
{
    public interface IUserService
    {
        List<UserDtos> GetAllUsers();

        void RegisterUser(UserDtos userDto);
    }
}
