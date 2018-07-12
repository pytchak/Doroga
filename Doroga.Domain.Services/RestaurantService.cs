using System;
using Doroga.Domain.Contracts;
using System.Collections.Generic;
using Doroga.Infrastructure.Common;
using Doroga.Infrastructure;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IDependencyResolver _dependencyResolver;

        public RestaurantService(IDependencyResolver dependencyResolver)
        {
            _dependencyResolver = dependencyResolver;
        }

        public IEnumerable<RestaurantEntity> GetAllRestaurants()
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.RestaurantRepository.GetAllRestaurants();
            }
        }

        public RestaurantEntity GetRestaurantById(string restaurantId)
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.RestaurantRepository.GetRestaurantById(restaurantId);
            }
        }

        public void CreateRestaurant(RestaurantEntity restaurant, string currentRestaurantId)
        {
            if (restaurant == null)
            {
                throw new ArgumentException("RestaurantEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentRestaurantId))
            {
                throw new ArgumentException("CurrentRestaurantId cannot be Null or empty.");
            }

            //DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.RestaurantRepository.CreateRestaurant(restaurant);
                unitOfWork.SaveChanges();
            }
        }

        public void UpdateRestaurant(RestaurantEntity restaurant, string currentRestaurantId)
        {

            if (restaurant == null)
            {
                throw new ArgumentException("RestaurantEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentRestaurantId))
            {
                throw new ArgumentException("CurrentRestaurantId cannot be Null or empty.");
            }

            //DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.RestaurantRepository.UpdateRestaurant(restaurant);
                unitOfWork.SaveChanges();
            }
        }
    }
}
