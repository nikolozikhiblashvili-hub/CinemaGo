using Cinema.Domain.Domain;
using Cinema.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Application.Services
{
    public class UserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void RegisterUser(User user)
        {
            if (user == null)
            {
                Console.WriteLine("not valid user");
            }
            if(user.Age<0)
            {
                Console.WriteLine("not valid age");
            }
            _userRepository.Save(user);


        }

        public List<User> GetAllUsers()
        {
            try
            {
                var usersList = _userRepository.GetAll();

                if (usersList == null || usersList.Count == 0)
                {
                    throw new InvalidOperationException("No users found.");
                }

                return usersList;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting users.", ex);
            }
        }




    }

  
}
