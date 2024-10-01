﻿using BodegaVinos.Entities;

namespace BodegaVinos.Repository
{
    public class UserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
            _users = new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "Nicolas",
                    Password = "Nicolas"
                },
                new User
                {
                    Id = 2,
                    Username = "Nico",
                    Password = "Nico"
                }
            };
        }
        public List<User> GetUsers() => _users;


        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}
