using System.Collections.Generic;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<UserEntity> GetAllUsers();
        UserEntity GetUserById(string id);
    }
}
