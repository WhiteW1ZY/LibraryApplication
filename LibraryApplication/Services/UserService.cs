using Library.Application.Db;
using Library.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.ApplicationLogic.Services
{
    public class UserService
    {
        private readonly LibraryContext _context;

        public UserService(LibraryContext context)
        {
            _context = context;
        }

        public async Task<int> CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user.UserId;
        }
        public async Task<int> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user != null)
                {
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync();
                }
            return user.UserId;
        }

        public async Task<int> UpdateUser(int id, string userName, string userPassword)
        {
            var user = await _context.Users.FindAsync(id);
            if(user != null)
            {
                user.Name = userName;
                user.Password = userPassword;
            }
            await _context.SaveChangesAsync();
            return user.UserId;
        }

        public async Task<List<User>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User?> GetUserFromAuth(string login, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync
                (
                    u => u.Name == login
                &&  u.Password == password
                );
            return user;
        }

    }
}
