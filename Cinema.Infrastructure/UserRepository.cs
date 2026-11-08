using Cinema.Domain.Domain;
using Cinema.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly string _path = @"C:\Users\Nikol\source\repos\c#-1\Project Of C#\Cinema.Infrastructure\Data\Users.txt";

        public void Save(User user)
        {
          File.AppendAllLines(_path, new List<string> { user.ToString() });
        }

      public List<User> GetAll()
        {
            var userlines = File.ReadAllLines(_path);
            List<User> usersList = new List<User>();
            foreach (var line in userlines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split(',');

                if (parts.Length < 3)
                    continue;

                User user = new User();

                user.Name = parts[0];
                user.Surname = parts[1];
                user.Age = int.Parse(parts[2]);

                usersList.Add(user);
            }
        
            return usersList;
        }
    }
}
