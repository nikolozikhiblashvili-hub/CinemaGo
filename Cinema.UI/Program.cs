using Cinema.Application.Services;
using Cinema.Domain.Domain;
using Cinema.Domain.Interface;
using Cinema.Infrastructure;

namespace Cinema.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserRepository userRepository = new UserRepository();
            UserService userService= new UserService(userRepository);

            userService.RegisterUser(new User { Name = "John", Surname = "Doe", Age = 30 });
        
            var users = userService.GetAllUsers();
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }

        }

    }
}
