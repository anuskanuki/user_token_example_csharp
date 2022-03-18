using ApiAuth.Models;

namespace ApiAuth.DTOs
{
    public class UserOutputDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

        public static UserOutputDto FromUser(User model)
        {
            return new UserOutputDto
            {
                Id = model.Id,
                Username = model.Username,
                Role = model.Role,
            };
        }
    }
}
