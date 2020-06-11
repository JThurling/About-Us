using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.Interface
{
    public interface IUserService
    {
        Task<IReadOnlyList<UserEntity>> GetUserInfo();
    }
}