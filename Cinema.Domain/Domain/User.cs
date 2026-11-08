using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Domain
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public override string? ToString()
        {
            return $"User:{Name}|{Surname}|{Age}";
        }
    }
}
