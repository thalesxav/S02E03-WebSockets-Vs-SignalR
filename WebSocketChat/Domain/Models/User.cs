using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSocketServer.Domain.Models
{
    public class User: Entity
    {
        public User(Guid id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        // Empty constructor for EF
        protected User() { }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }
    }
}
