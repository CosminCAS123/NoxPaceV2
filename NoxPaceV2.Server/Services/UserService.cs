using NoxPaceV2.Server.Models;
using NoxPaceV2.Server.Repos;

namespace NoxPaceV2.Server.Services
{
    public class UserService
    {
        private readonly UserRepository userRepository;

        public UserService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<int> AddUserExample()
        {
            var newUser = new User
            {
                Email = "testexample@gmail.com",
                PasswordHash = "atatatatatatatata",
                Username = "Test"
            };

           var id = await this.userRepository.AddUserAsync(newUser);
           return id;
        }
    }
}
