using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Core.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastucture.Data
{
    public class UserService : IUserService
    {
        private readonly UserContext _context;

        public UserService(UserContext context)
        {
            _context = context;
        }
        
        public async Task<IReadOnlyList<UserEntity>> GetUserInfo()
        {
            return await _context.UserInformation.ToListAsync();
        }
    }
}