using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Application.Exceptions
{
    internal class NotValidUsersException :Exception
    {
        const string DefaultMessage = "The users are not valid.";
        public NotValidUsersException() : base(DefaultMessage)
        {
        }

        public NotValidUsersException(string message) : base(message)
        {
        }
    }
}
