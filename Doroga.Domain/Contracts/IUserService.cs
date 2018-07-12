using System.Collections.Generic;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Contracts
{
    public interface IUserService
    {
        UserEntity GetUserById(string userId);
        IEnumerable<UserEntity> GetAllUsers();
    }
}
