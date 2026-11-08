using Cinema.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Interface
{
    public interface IUserRepository
    {
        void Save(User user);
        List<User> GetAll();
    }
}
