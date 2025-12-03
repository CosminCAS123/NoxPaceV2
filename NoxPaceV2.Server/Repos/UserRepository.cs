using Microsoft.Extensions.Logging;
using NoxPaceV2.Server.Data;
using NoxPaceV2.Server.Models;

namespace NoxPaceV2.Server.Repos
{
    public class UserRepository 
    {
      
        private readonly NoxPaceDbContext _context;

        public UserRepository(NoxPaceDbContext context)
        {
            this._context = context;
        }

        public async Task<int> AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }
    }

}

