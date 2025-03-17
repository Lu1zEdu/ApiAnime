using API.Domain.Entity;
using API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Repository;

    public class UserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<bool> CreateUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> DeactivateUserAsync(Guid userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

            user.Active = false;
            await _context.SaveChangesAsync();
            return true;
        }
    }
