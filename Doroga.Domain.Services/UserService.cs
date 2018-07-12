using System.Collections.Generic;
using Doroga.Domain.Entities;
using Doroga.Domain.Contracts;
using Doroga.Infrastructure.Common;
using Doroga.Infrastructure;

namespace Doroga.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IDependencyResolver _dependencyResolver;

        public UserService(IDependencyResolver dependencyResolver)
        {
            _dependencyResolver = dependencyResolver;
        }

        public UserEntity GetUserById(string userId)
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.UserRepository.GetUserById(userId);
            }
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.UserRepository.GetAllUsers();
            }
        }
    }
}
