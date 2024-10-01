using BodegaVinos.Dtos;
using BodegaVinos.Entities;
using BodegaVinos.Repository;

namespace BodegaVinos.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public List<UserDtos> GetAllUsers()
        {
            var users = _repository.GetUsers();
            return users.Select(x => new UserDtos
            {
                Username = x.Username,
                Password = x.Password,
            }).ToList();
        }
        public void RegisterUser(UserDtos userDto)
        {
            var user = new User
            {
                Username = userDto.Username,
                Password = userDto.Password,
            };
            _repository.AddUser(user);
        }
    }
}
