using ApiAuth.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiAuth.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, Username = "Flash", Password = "flash", Role = "manager" },
                new User { Id = 2, Username = "XPTO", Password = "xpto", Role = "employee" },
            };

            return users
                .Where(u => u.Username.Equals(username) && u.Password.Equals(password))
                .FirstOrDefault();
        }
    }
}
